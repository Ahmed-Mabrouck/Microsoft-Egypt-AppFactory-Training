using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Delegates Scenario Testing.
            //var delegatesScenario = new DelegatesScenario.Delegates();
            //delegatesScenario.PrintArea(CalculateSquareArea, new double[] { 5 });
            //delegatesScenario.PrintArea(CalculateCircleArea, new double[] { 4 });
            #endregion

            #region Built-In Delegates Scenario Testing.
            //var builtinDelegatesScenario = new BuiltinDelegatesScenario.BuiltinDelegates();
            //builtinDelegatesScenario.PrintArea(CalculateSquareArea, new double[] { 5 });
            //builtinDelegatesScenario.PrintArea(CalculateCircleArea, new double[] { 4 });
            #endregion
        }


        #region Shapes Areas Calculation Equations.
        static double CalculateSquareArea(double[] dimensions)
        {
            return dimensions[0] * dimensions[0];
        }

        static double CalculateCircleArea(double[] dimensions)
        {
            return 3.14 * (dimensions[0] / 2) * (dimensions[0] / 2);
        }
        #endregion
    }
}
