using System;

namespace _05.AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalSum = 0;
            double averageNumber = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                totalSum += number;
            }
            averageNumber = 1.0 * totalSum / n;
            Console.WriteLine($"{averageNumber:f2}");
        }
    }
}
