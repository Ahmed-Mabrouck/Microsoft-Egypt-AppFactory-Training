using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven.DelegatesScenario
{
    public delegate double AreaCalculation(double[] dimensions);

    public class Delegates
    {
        public void PrintArea(AreaCalculation area, double[] dimensions)
        {
            Console.WriteLine("Area = " + area(dimensions));
        }
    }
}
