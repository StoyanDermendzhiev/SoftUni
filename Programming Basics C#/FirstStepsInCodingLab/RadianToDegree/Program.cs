using System;

namespace RadianToDegree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double radians = double.Parse(Console.ReadLine());
            //Calculations
            double degrees = radians * 180 / Math.PI;
            //Output
            Console.WriteLine(Math.Round(degrees,0));
        }
    }
}
