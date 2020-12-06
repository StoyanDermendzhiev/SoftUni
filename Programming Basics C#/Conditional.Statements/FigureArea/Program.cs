using System;

namespace FigureArea
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            double area = 0.0;
            if (shape == "square")
            {
                Console.Write("a=");
                double side = double.Parse(Console.ReadLine());
                area = side * side;
            }
            else if (shape == "rectangle")
            {
                Console.Write("a=");
                double sideA = double.Parse(Console.ReadLine());
                Console.Write("b=");
                double sideB = double.Parse(Console.ReadLine());
                area = sideA * sideB;
            }
            else if (shape == "circle")
            {
                Console.Write("r=");
                double R = double.Parse(Console.ReadLine());
                area = Math.PI * R * R;
            }
            else if (shape == "triangle")
            {
                Console.Write("c=");
                double c = double.Parse(Console.ReadLine());
                Console.Write("hc=");
                double hc = double.Parse(Console.ReadLine());
                area = c * hc / 2;
            }
            Console.WriteLine($"{area:F3}");
        }
    }
}
