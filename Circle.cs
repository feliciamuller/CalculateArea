using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    internal class Circle : Geometri
    {
        public double Radius { get; set; }

        //create constructor and give value to the property
        public Circle()
        {
            Radius = 8.5;
            Console.WriteLine($"Cirkelns radie är: {Radius}");
        }

        //calculate and return result of area
        public override double Area()
        {
            double result = Math.PI * Radius * Radius;
            Console.WriteLine("Arean av cirkeln är: " + result);
            Console.WriteLine("");
            return result;
        }
    }
}
