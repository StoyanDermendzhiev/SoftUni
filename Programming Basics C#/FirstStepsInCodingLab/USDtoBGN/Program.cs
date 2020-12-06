using System;

namespace USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double usd = double.Parse(Console.ReadLine());

            //Calculations
            double bgn = usd * 1.79549;

            //Output
            Console.WriteLine("{0:F2}", bgn);
        }
    }
}
