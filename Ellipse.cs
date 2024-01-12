using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    internal class Ellipse : Geometri
    {
        public double LargeAxis { get; set; }
        public double SmallAxis { get; set; }

        //create constructor and give value to the propertys
        public Ellipse()
        {
            LargeAxis = 10;
            SmallAxis = 5;
            Console.WriteLine($"Huvudaxeln på ellipsen är: {LargeAxis}\nMindre axeln på ellipsen är: {SmallAxis}");
        }

        //calculate and return result of area
        public override double Area()
        {
            double result = Math.PI * LargeAxis / 2 * SmallAxis / 2;
            Console.WriteLine("Arean av ellipsen är: " + result);
            Console.WriteLine("");
            return result;
        }
    }
}
