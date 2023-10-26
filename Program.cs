namespace Labb_7_OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating objects and call methods
            Rectangle myRectangle = new Rectangle();
            myRectangle.Area();

            Square mySquare = new Square();
            mySquare.Area();

            Circle myCircle = new Circle();
            myCircle.Area();

            Parallelogram myParallelogram = new Parallelogram();
            myParallelogram.Area();

            Ellipse myEllipse = new Ellipse();
            myEllipse.Area();

        }
    }
}