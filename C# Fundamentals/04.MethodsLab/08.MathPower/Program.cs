using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double result = PowerNumber(number, power);
            Console.WriteLine(result);
        }

        private static double PowerNumber(double number, double power)
        {
            return Math.Pow(number, power);
        }
    }
}
