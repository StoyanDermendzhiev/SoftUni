using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
                        
            int output = Subtract(Sum(num1, num2), num3);
            Console.WriteLine(output);
        }

        private static int Subtract(int sumNum, int num3)
        {
            return sumNum - num3;
        }

        private static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
