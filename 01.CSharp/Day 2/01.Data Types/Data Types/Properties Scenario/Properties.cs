using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.PropertiesScenario
{
    public class Properties
    {
        /// <summary>
        /// Autmatic Property Declaration Example. 
        /// Snippet: prop + double Tab.
        /// </summary>
        public int AutmaticProperty { get; set; }

        /// <summary>
        /// Full Property Declaration (With Back Property Field) Example.
        /// Snippet: propfull + double Tab.
        /// </summary>
        private int backProperty;

        public int Property
        {
            get { return backProperty; }
            set { backProperty = value; }
        }
        /// <summary>
        /// Read-Only Property Declaration Example (Private Setter).
        /// </summary>
        public int ReadOnlyProperty { get; private set; }

        /// <summary>
        /// Write-Only Property Declaration Example (Private Getter).
        /// </summary>
        public int WriteOnlyProperty { private get; set; }

        /// <summary>
        /// Validating Input Before Setting The Property Value.
        /// </summary>
        private int validationProperty;

        public int ValidationProperty
        {
            get { return validationProperty; }
            set { if (value >= 5) validationProperty = value; }
        }

        /// <summary>
        /// Computation On The Input Before Setting Or Getting The Property Value.
        /// </summary>
        private int computationProperty;

        public int ComputationProperty
        {
            get { return validationProperty / 10; }
            set { validationProperty = value * 10; }
        }
    }
}
