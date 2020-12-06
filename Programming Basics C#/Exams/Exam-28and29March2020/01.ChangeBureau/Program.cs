using System;
using System.Dynamic;

namespace _01.ChangeBureau
{
    class Program
    {
        static void Main(string[] args)
        {
            //Static data
            double bitcoinCourse = 1168;
            double usdCourse = 1.76;
            double euroCourse = 1.95;
            double cnyCourse = 0.15 * usdCourse;
            //Input
            double bitcoin = double.Parse(Console.ReadLine());
            double cny = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());
            //Calculations
            double euro = ((bitcoin * bitcoinCourse + cny * cnyCourse) * (1 - commission / 100))/euroCourse;
            //Output
            Console.WriteLine($"{euro:F2}");
        }
    }
}
