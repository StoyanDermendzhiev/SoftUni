using System;

namespace _03.LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double lenght1 = GetLenght(x1, y1, x2, y2);
            double lenght2 = GetLenght(x3, y3, x4, y4);

            double x1y1Distance = DistanceToTheCenterOfTheCoordinateSystem(x1, y1);
            double x2y2Distance = DistanceToTheCenterOfTheCoordinateSystem(x2, y2);
            double x3y3Distance = DistanceToTheCenterOfTheCoordinateSystem(x3, y3);
            double x4y4Distance = DistanceToTheCenterOfTheCoordinateSystem(x4, y4);

            if (lenght1 >= lenght2)
            {
                if (x1y1Distance <= x2y2Distance)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                if (x3y3Distance <= x4y4Distance)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");

                }
            }
        }

        private static double GetLenght(double x1, double y1, double x2, double y2)
        {
            double a = 0;

            if (x1 < 0 || x2 < 0)
            {
                a = Math.Abs(x1) + Math.Abs(x2);
            }
            else
            {
                a = Math.Abs(x1 - x2);
            }

            double b = 0;

            if (y1 < 0 || y2 < 0)
            {
                b = Math.Abs(y1) + Math.Abs(y2);
            }
            else
            {
                b = Math.Abs(y1 - y2);
            }

            double aPow = Math.Pow(Math.Abs(a), 2);
            double bPow = Math.Pow(Math.Abs(b), 2);
            double lenght = Math.Sqrt(aPow + bPow);

            return lenght;
        }

        private static double DistanceToTheCenterOfTheCoordinateSystem(double x, double y)
        {
            double xPow = Math.Pow(Math.Abs(x), 2);
            double yPow = Math.Pow(Math.Abs(y), 2);
            double distance = Math.Sqrt(xPow + yPow);

            return distance;
        }
    }
}

