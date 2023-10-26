using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7_OOP_Polymorphism
{
    internal class Parallelogram : Geometri
    {
        public double Lenght { get; set; }
        public double Height { get; set; }

        //create constructor and give value to the propertys
        public Parallelogram()
        {
            Lenght = 22.8;
            Height = 13.5;
            Console.WriteLine($"Parallelogramens längd är: {Lenght}\nParallelogramens höjd är: {Height}");
        }

        //calculate and return result of area
        public override double Area()
        {
            double result = Lenght * Height;
            Console.WriteLine("Arean av parallelogramen är: " + result);
            Console.WriteLine("");
            return result;
        }
    }
}
