using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Asynchrony
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        #region Non-Async Heavy Process Scenario.
        private void NonAsyncHeavyProcess(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = "Testing... Please Wait.";
            var timer = new System.Diagnostics.Stopwatch();
            timer.Start();
            for (int i = 0; i <= 5000; i++)
                System.Diagnostics.Debug.WriteLine(i);
            timer.Stop();
            ResultTextBlock.Text = "Scenario: Non-Async Heavy Process Scenario.\n" + timer.Elapsed.Seconds + " Seconds of Freezing UI for 5000 Iteration Single Line Loop.";
        }
        #endregion

        #region Async Heavy Process Scenario.
        private async void AsyncHeavyProcess(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = "Testing... Please Wait.";
            var timer = new System.Diagnostics.Stopwatch();
            timer.Start();
            var task = System.Threading.Tasks.Task.Run(() =>
                {
                    for (int i = 0; i <= 5000; i++)
                        System.Diagnostics.Debug.WriteLine(i);
                });
            timer.Stop();
            var result = "Scenario: Async Heavy Process Scenario.\n" + timer.Elapsed.Seconds + " Seconds of Freezing UI for 5000 Iteration Task to Start.";
            timer.Start();
            await task;
            timer.Stop();
            result += "\n" + timer.Elapsed.Seconds + " Seconds of Interactive UI for the Task to Complete Asynchronously in A Separate Thread";
            ResultTextBlock.Text = result;
        }
        #endregion

        #region Caching Using TaskFromResult Scenario.

        public Dictionary<string, double> Cache { get; set; }
        public string ResultSource { get; set; }

        private async void CachingUsingTaskFromResult(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = "Testing... Please Wait.";
            Cache = new Dictionary<string, double>() { { "3*3", 9 } };
            var result = "Scenario: Caching Using TaskFromResult.\n3×3 = " + await CalculateResult(3, 3) + "[" + ResultSource + "].";
            result += "\n3×4 = " + await CalculateResult(3, 4) + " [" + ResultSource + "].";
            result += "\n3×4 = " + await CalculateResult(3, 4) + " [" + ResultSource + "].";
            ResultTextBlock.Text = result;
        }

        private async System.Threading.Tasks.Task<double> CalculateResult(double x, double y)
        {
            if (Cache.ContainsKey(x.ToString() + "*" + y.ToString()))
            {
                ResultSource = "Cache";
                return await System.Threading.Tasks.Task.FromResult(Cache[x.ToString() + "*" + y.ToString()]);
            }
            else
            {
                ResultSource = "Server";
                var task = GetDataFromServer(x, y);
                Cache[x.ToString() + "*" + y.ToString()] = await task;
                return await task;
            }
        }

        private async System.Threading.Tasks.Task<double> GetDataFromServer(double x, double y)
        {
            return await System.Threading.Tasks.Task.Run(() =>
            {
                return x * y;
            });
        }

        #endregion

        #region Mutliple Tasks Scenarion With/Without WhenAll Pattern.
        private async void MultipleTasksWithoutWhenAll(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = "Testing... Please Wait.";
            var timer = new System.Diagnostics.Stopwatch();
            timer.Start();
            var results = new string[10];
            var uris = new Uri[10] {
                new Uri("http://stackoverflow.com/"),
                new Uri("http://www.goal.com/"),
                new Uri("http://www.yallakora.com/"),
                new Uri("https://www.jumia.com.eg/"),
                new Uri("http://www.gsmarena.com/"),
                new Uri("http://www.phonearena.com/"),
                new Uri("http://www.gadget.com/"),
                new Uri("http://www.engadget.com/"),
                new Uri("https://www.yashry.com/"),
                new Uri("https://compume.com.eg/"),
            };
            for (int i = 0; i < 10; i++)
                results[i] = await DummyTask(uris[i]);
            timer.Stop();
            ResultTextBlock.Text = "Scenario: Multiple Tasks Scenario Without WhenAll.\n" + timer.Elapsed.TotalMilliseconds + " Milli Seconds for 10 Tasks to Finish.";
        }

        private async void MultipleTasksWithWhenAll(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = "Testing... Please Wait.";
            var timer = new System.Diagnostics.Stopwatch();
            timer.Start();
            var tasks = new System.Threading.Tasks.Task<string>[10] {
                DummyTask(new Uri("http://stackoverflow.com/")),
                DummyTask(new Uri("http://www.goal.com/")),
                DummyTask(new Uri("http://www.yallakora.com/")),
                DummyTask(new Uri("https://www.jumia.com.eg/")),
                DummyTask(new Uri("http://www.gsmarena.com/")),
                DummyTask(new Uri("http://www.phonearena.com/")),
                DummyTask(new Uri("http://www.gadget.com/")),
                DummyTask(new Uri("http://www.engadget.com/")),
                DummyTask(new Uri("https://www.yashry.com/")),
                DummyTask(new Uri("https://compume.com.eg/")),
            };
            var results = await System.Threading.Tasks.Task.WhenAll<string>(tasks);
            timer.Stop();
            ResultTextBlock.Text = "Scenario: Multiple Tasks Scenario With WhenAll.\n" + timer.Elapsed.TotalMilliseconds + " Milli Seconds for 10 Tasks to Finish.";
        }

        private async System.Threading.Tasks.Task<string> DummyTask(Uri uri)
        {
            return await new System.Net.Http.HttpClient().GetStringAsync(uri);
        }

        #endregion

        #region Similar Tasks Scenario With WhenAny Pattern.
        private async void SimilarTasksWithWhenAny(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = "Testing... Please Wait.";
            var timer = new System.Diagnostics.Stopwatch();
            timer.Start();
            var tokenSource = new System.Threading.CancellationTokenSource();
            var tasks = new System.Threading.Tasks.Task<string>[10] {
                CancellableDummyTask(new Uri("http://stackoverflow.com/"), tokenSource.Token),
                CancellableDummyTask(new Uri("http://stackoverflow.com/"), tokenSource.Token),
                CancellableDummyTask(new Uri("http://stackoverflow.com/"), tokenSource.Token),
                CancellableDummyTask(new Uri("http://stackoverflow.com/"), tokenSource.Token),
                CancellableDummyTask(new Uri("http://stackoverflow.com/"), tokenSource.Token),
                CancellableDummyTask(new Uri("http://stackoverflow.com/"), tokenSource.Token),
                CancellableDummyTask(new Uri("http://stackoverflow.com/"), tokenSource.Token),
                CancellableDummyTask(new Uri("http://stackoverflow.com/"), tokenSource.Token),
                CancellableDummyTask(new Uri("http://stackoverflow.com/"), tokenSource.Token),
                CancellableDummyTask(new Uri("http://stackoverflow.com/"), tokenSource.Token),
            };
            var results = await System.Threading.Tasks.Task.WhenAny<string>(tasks);
            tokenSource.Cancel();
            timer.Stop();
            ResultTextBlock.Text = "Scenario: Similar Tasks Scenario With WhenAny.\n" + timer.Elapsed.TotalMilliseconds + " Milli Seconds the First Task to Complete.";
        }

        private async Task<string> CancellableDummyTask(Uri uri, System.Threading.CancellationToken token)
        {
            return await new System.Net.Http.HttpClient().GetStringAsync(uri).AsAsyncOperation<string>().AsTask(token);
        }
        #endregion
    }
}
