using System;
using System.Linq;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = Math.Abs(int.Parse(Console.ReadLine()));

            int output = GetMultipleOfEvenAndOdds(inputNumber);
            Console.WriteLine(output);
        }

        private static int GetSumOfOddDigits(int input)
        {

            int sumOfOddDigits = 0;
            int remainder = 0;
            while (input > 0)
            {
                remainder = input % 10;
                input /= 10;
                if (remainder % 2 != 0)
                {
                    sumOfOddDigits += remainder;
                }
            }
            return sumOfOddDigits;
        }
        private static int GetSumOfEvenDigits(int input)
        {
            int sumOfEvenDigits = 0;
            int remainder = 0;
            while (input > 0)
            {
                remainder = input % 10;
                input /= 10;
                if (remainder % 2 == 0)
                {
                    sumOfEvenDigits += remainder;
                }
            }
            return sumOfEvenDigits;
        }
        private static int GetMultipleOfEvenAndOdds(int input)
        {
            return GetSumOfOddDigits(input) * GetSumOfEvenDigits(input);
        }
    }
}
