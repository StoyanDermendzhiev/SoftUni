using System;
using System.Linq;

namespace _01.RecursiveArraySum
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();

            long sum = Sum(numbers, 0);

            Console.WriteLine(sum);

        }

        public static long Sum(int[] numbers, int index)
        {
            if (index == numbers.Length - 1)
            {
                return numbers[index];
            }

            return numbers[index] + Sum(numbers, index + 1);
        }
    }
}
