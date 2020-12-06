using System;
using System.Linq;

namespace _03.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] realNumbers = Console.ReadLine()
                                    .Split()
                                    .Select(double.Parse)
                                    .ToArray();
            for (int i = 0; i < realNumbers.Length; i++)
            {
                if (realNumbers[i].ToString() == "-0")
                {
                    realNumbers[i] = 0;
                }
                Console.WriteLine($"{realNumbers[i]} => {Math.Round(realNumbers[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
