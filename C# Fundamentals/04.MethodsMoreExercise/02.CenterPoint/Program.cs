using System;

namespace _02.CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double distancePoint1 = DistanceToTheCenterOfTheCoordinateSystem(x1, y1);
            double distancePoint2 = DistanceToTheCenterOfTheCoordinateSystem(x2, y2);

            if (distancePoint1 <= distancePoint2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
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
