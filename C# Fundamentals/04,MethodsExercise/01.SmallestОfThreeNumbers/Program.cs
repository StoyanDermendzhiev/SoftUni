using System;

namespace _01.SmallestОfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            SmallestОfThreeNumbers(num1, num2, num3);
        }

        private static void SmallestОfThreeNumbers(int num1, int num2, int num3)
        {
            int smallestNum = int.MaxValue;
            if (smallestNum > num1)
            {
                smallestNum = num1;
            }
            if (smallestNum > num2)
            {
                smallestNum = num2;
            }
            if (smallestNum > num3)
            {
                smallestNum = num3;
            }

            Console.WriteLine(smallestNum);
        }
    }
}
