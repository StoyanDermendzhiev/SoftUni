using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Shape shape = new Circle(5.5);
            Console.WriteLine(shape.CalculateArea());
            Console.WriteLine(shape.CalculatePerimeter());
            Console.WriteLine(shape.Draw());

            shape = new Rectangle(2, 3);
            Console.WriteLine(shape.CalculateArea());
            Console.WriteLine(shape.CalculatePerimeter());
            Console.WriteLine(shape.Draw());
        }
    }
}
