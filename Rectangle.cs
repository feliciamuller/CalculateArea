using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7_OOP_Polymorphism
{

    internal class Rectangle : Geometri
    {
        public double Lenght { get; set; }
        public double Height { get; set; }

        //create constructor and give value to the propertys
        public Rectangle()
        {
            Lenght = 15.5;
            Height = 10.1;
            Console.WriteLine($"Rektangelns längd: {Lenght}\nRektangelns höjd: {Height}");
            
        }

        //calculate and return result of area
        public override double Area()
        {
            double result = Lenght * Height;
            Console.WriteLine("Arean av rektangeln är: " + result);
            Console.WriteLine("");
            return result;  

        }

    }
}
