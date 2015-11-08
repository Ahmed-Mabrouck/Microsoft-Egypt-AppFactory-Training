using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming.Class_Hierarchy_Scenario
{
    public abstract class Shape
    {
        public int Name { get; set; }
        public int NumberOfLines { get; set; }

        public abstract double CalculateArea(double[] dimensions);

        public virtual void SayMyName()
        {
            Console.WriteLine("My Name Is: " + this.Name);
        }
    }

    public class Triangle : Shape
    {
        public override double CalculateArea(double[] dimensions)
        {
            return (dimensions[0] * dimensions[1]) / 2;
        }

        public override void SayMyName()
        {
            Console.WriteLine("I Am " + this.Name);
        }
    }

    public interface IHaveVolume
    {
        double CalculateVolume(double[] dimensions);
    }
    public class Cube : Shape, IHaveVolume
    {
        public override double CalculateArea(double[] dimensions)
        {
            return dimensions[0] * dimensions[0] * 6;
        }

        public double CalculateVolume(double[] dimensions)
        {
            return dimensions[0] * dimensions[0] * dimensions[0];
        }
    }
}
