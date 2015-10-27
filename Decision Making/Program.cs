using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void IfStatementScenario(int param)
        {
            if (param == 0)
            {
                Console.WriteLine("False.");
            }
            else if(param == 1)
            {
                Console.WriteLine("True.");
            }
            else
            {
                Console.WriteLine("Undefined.");
            }
        }

        static void SwitchCaseStatementScenario(int param)
        {
            switch(param)
            {
                case 0:
                    Console.WriteLine("False.");
                    break;
                case 1:
                    Console.WriteLine("True.");
                    break;
                default:
                    Console.WriteLine("Undefined.");
                    break;
            }
        }

        static void ForLoopStatementScenario(int param)
        {
            for (int i = 0; i < param; i++)
            {
                Console.WriteLine(i.ToString());
            }
        }

        static void WhileStatementScenario(int param)
        {
            int i = 0;
            while (i++ < param)
            {
                Console.WriteLine(i.ToString());
            }
        }

        static void DoWhileStatementScenario(int param)
        {
            int i = 0;
            do
            {
                Console.WriteLine(i.ToString());
            } while (i++ < param);
        }

        static void ForeachStatementScenario(int[] param)
        {
            foreach (var i in param)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
