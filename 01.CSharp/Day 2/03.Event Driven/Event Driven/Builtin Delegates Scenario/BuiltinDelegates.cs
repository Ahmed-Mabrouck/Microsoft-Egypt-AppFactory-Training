using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven.BuiltinDelegatesScenario
{
    public class BuiltinDelegates
    {
        public void PrintArea(Func<double[], double> area, double[] dimensions)
        {
            Console.WriteLine("Area = " + area(dimensions));
        }
    }
}
