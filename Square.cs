using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    internal class Square : Geometri
    {
        public double Side { get; set; }

        //create constructor and give value to the property
        public Square()
        {
            Side = 7;
            Console.WriteLine($"Sidorna på fyrkanten är: {Side}");
        }

        //calculate and return result of area
        public override double Area()
        {
            double result = Side * Side;
            Console.WriteLine("Arean av fyrkanten är: " + result);
            Console.WriteLine("");
            return result;

        }
    }
}
