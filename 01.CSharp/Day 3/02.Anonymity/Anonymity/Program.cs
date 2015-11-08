using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymity
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Anonymous Type Scenario.
            var student = new { ID = 1, Name = "Ahmed" };
            Console.WriteLine("Student Information: ID=" + student.ID + ", Name=" + student.Name +".");
            #endregion

            #region Anonymous Methods Scenario.
            ProcessNumbers(
                delegate (double[] numbers)
                {
                    var result = 0.0;
                    foreach (var number in numbers)
                        result += number;
                    return result;
                }, 
                new double[] {1.1, 2.2, 3.3, 4.4 });
            #endregion

            #region Lambda Expressions Scenario.
            ProcessNumbers(
                (numbers) =>
                {
                    var result = 0.0;
                    foreach (var number in numbers)
                        result += number;
                    return result;
                },
                new double[] { 1.1, 2.2, 3.3, 4.4 });
            #endregion
        }

        #region Method That Takes Func<double[], double> Delegate And Invokes It.
        private static void ProcessNumbers(Func<double[], double> process, double[] numbers)
        {
            Console.WriteLine(process(numbers).ToString());
        }
        #endregion
    }
}
