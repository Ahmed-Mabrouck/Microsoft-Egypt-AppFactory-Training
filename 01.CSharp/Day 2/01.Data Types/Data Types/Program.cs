using DataTypes.ExtensionMethodsScenario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Properties Scenario Testing.
            //var propertiesScenario = new DataTypes.PropertiesScenario.Properties();

            //propertiesScenario.ComputationProperty = 5;
            //var computationProperty = propertiesScenario.ComputationProperty;

            //propertiesScenario.ReadOnlyProperty = 5; // Error Trying Setting Read-Only Property.
            //var readOnlyProperty = propertiesScenario.ReadOnlyProperty;

            //propertiesScenario.WriteOnlyProperty = 5;
            //var writeOnlyProperty = propertiesScenario.WriteOnlyProperty; // Error Getting Write-Only Property.
            #endregion

            #region Extension Methods Scenario Testing.
            //var x = 5;
            //Console.WriteLine(x.Square());
            //Console.WriteLine(x.Power(4));
            #endregion

            #region Indexers Scenario Testing.
            //var indexer = new IndexersScenario.Indexers();
            //var point = indexer[3]; // Getting Point Values Through Indexer.
            //Console.WriteLine("Point No. 4 {X=" + point['Z'] + " Y=" + point['Y'] + " Z=" + point['Z'] + "}.");
            //indexer[3] = new Dictionary<char, int> {
            //        { 'X', 8 },
            //        { 'Y', 13 },
            //        { 'Z', 32 }
            //};
            //var newPoint = indexer[3]; // Setting Point Values Through Indexer.
            //Console.WriteLine("New Point No. 4 {X=" + newPoint['Z'] + " Y=" + newPoint['Y'] + " Z=" + newPoint['Z'] + "}.");
            #endregion
        }
    }
}
