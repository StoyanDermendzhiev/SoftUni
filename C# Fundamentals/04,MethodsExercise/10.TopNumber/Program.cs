using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 17; i <= inputNumber; i++)
            {
                bool isTopNumber = TopNumber(i);

                if (isTopNumber)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool TopNumber(int num)
        {
            string currentNum = num.ToString();
            int digitSum = 0;
            bool atLeastOneOddDigit = false;
            bool digitSumDivisibleBy8 = false;

            for (int i = 0; i < currentNum.Length; i++)
            {
                digitSum += (int)currentNum[i];

                if ((int)currentNum[i] % 2 != 0)
                {
                    atLeastOneOddDigit = true;
                }
            }

            if (digitSum % 8 == 0)
            {
                digitSumDivisibleBy8 = true;
            }

            return atLeastOneOddDigit && digitSumDivisibleBy8;
        }
    }
}
