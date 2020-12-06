using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumber = int.Parse(Console.ReadLine());
            var number = inputNumber.ToString(); 
            var totalSum = 0;

            for (int i = 0; i <= number.Length - 1; i++)
            {
                int digit = int.Parse(number[i].ToString());
                int digitSum = 1;
                for (int j = 1; j <= digit; j++)
                {
                    digitSum *= j;
                }
                totalSum += digitSum;
            }
            if (totalSum == inputNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
