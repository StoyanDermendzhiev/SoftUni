using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                        .Split()
                                        .Select(int.Parse)
                                        .ToList();

            List<char> inputString = Console.ReadLine()
                                            .ToList();

            string output = string.Empty;

            foreach (int element in numbers)
            {
                int sum = 0;
                int currentNumber = element;
                while (currentNumber > 0)
                {
                    sum += currentNumber % 10;
                    currentNumber /= 10;
                }

                if (sum > inputString.Count - 1)
                {
                    sum %= inputString.Count;
                }

                output += inputString[sum];
                inputString.RemoveAt(sum);
            }

            Console.WriteLine(output);
        }
    }
}

