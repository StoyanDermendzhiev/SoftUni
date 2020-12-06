using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string calculationType = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (calculationType == "add")
            {
                Add(num1, num2);
            }
            else if (calculationType == "multiply")
            {
                Multiply(num1, num2);
            }
            else if (calculationType == "substract")
            {
                Subtract(num1, num2);
            }
            else if (calculationType == "divide")
            {
                Divide(num1, num2);
            }
        }

        private static void Divide(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }

        private static void Subtract(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }

        private static void Multiply(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }

        private static void Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
    }
}
