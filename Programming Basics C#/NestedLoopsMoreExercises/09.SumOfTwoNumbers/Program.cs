using System;
using System.Threading;

namespace _09.SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int intervalStart = int.Parse(Console.ReadLine());
            int intervalFinish = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int count = 0;
            for (int number1 = intervalStart; number1 <= intervalFinish; number1++)
            {
                for (int number2 = intervalStart; number2 <= intervalFinish; number2++)
                {
                    count++;
                    if (number1 + number2 == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{count} ({number1} + {number2} = {magicNumber})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
        }
    }
}
