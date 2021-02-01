using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int[], int> getMinNumber = numbers =>
            {
                int minNumber = int.MaxValue;

                foreach (var num in numbers)
                {
                    if (minNumber > num)
                    {
                        minNumber = num;
                    }
                }

                return minNumber;
            };

            Console.WriteLine(getMinNumber(numbers));
        }
    }
}
