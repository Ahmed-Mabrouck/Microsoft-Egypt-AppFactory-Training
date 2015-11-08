using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.ExtensionMethodsScenario
{
    public static class IntExtensions
    {
        /// <summary>
        /// returns The Squared Power Of The Integer Number n.
        /// </summary>
        public static int Square(this int n)
        {
            return n ^ 2;
        }
        
        /// <summary>
        /// Calculates The Integer Number n Power p (n^p).
        /// </summary>
        /// <param name="power"></param>
        /// <returns></returns>
        public static int Power(this int n, int p)
        {
            return n ^ p;
        }
    }
}
