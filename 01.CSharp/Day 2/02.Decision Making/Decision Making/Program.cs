using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Making
{
    class Program
    {
        static void Main(string[] args)
        {
            #region If Statement Scenario.
            //var ifNumber = 5;
            //if (ifNumber == 5)
            //{
            //    Console.WriteLine("The Number Is" + 5);
            //}
            //else if (ifNumber < 5)
            //{
            //    Console.WriteLine("The Number Is Less Than " + 5);
            //}
            //else
            //{
            //    Console.WriteLine("The Number Is More Than " + 5);
            //}
            #endregion

            #region Switch/Case Statement Scenario.
            //var switchNumber = 5;
            //switch (switchNumber)
            //{
            //    case 5:
            //        Console.WriteLine("The Number Is" + 5);
            //        break;
            //    case 4:
            //        Console.WriteLine("The Number Is Less Than " + 5);
            //        break;
            //    default:
            //        Console.WriteLine("The Number Is More Than " + 5);
            //        break;
            //}
            #endregion

            #region While Loop Statement Scenario.
            //var whileNumber = -1;
            //// Loop With 10 Iterations.
            //while (++whileNumber < 10)
            //{
            //    Console.WriteLine(whileNumber);
            //}
            //// Loop With 0 Iterations.
            //while (++whileNumber < 10)
            //{
            //    Console.WriteLine(whileNumber);
            //}
            #endregion

            #region Do While Loop Statement Scenarion.
            var doWhileNumber = 0;
            // Loop With 10 Iterations.
            do
            {
                Console.WriteLine(doWhileNumber);
            } while (++doWhileNumber < 10);
            // Loop With 1 Iteration.
            do
            {
                Console.WriteLine(doWhileNumber);
            } while (++doWhileNumber < 10);
            #endregion

            #region For Loop Statement Scenarion.
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Foreach Loop Statement Scenario.
            //var foreachNumbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //foreach(var number in foreachNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

        }
    }
}
