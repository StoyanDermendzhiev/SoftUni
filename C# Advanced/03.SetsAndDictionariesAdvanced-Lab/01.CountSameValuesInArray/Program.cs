using System;
using System.Collections.Generic;

namespace _01.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine()
                                      .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<double, int> counts = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                double number = double.Parse(numbers[i]);

                if (!counts.ContainsKey(number))
                {
                    counts.Add(number, 0);
                }

                counts[number] += 1;
            }

            foreach (var number in counts)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
