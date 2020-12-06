using System;
using System.Text;

namespace _04.TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintTribonacciSequence(num);
        }

        private static void PrintTribonacciSequence(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.Write(GetTribonacciSequence(i) + " ");
            }
        }

        private static int GetTribonacciSequence(int num)
        {
            if (num == 1 || num == 2)
            {
                return 1;
            }

            if (num == 3)
            {
                return 2;
            }
            else
            {
                return GetTribonacciSequence(num - 1) +
                       GetTribonacciSequence(num - 2) +
                       GetTribonacciSequence(num - 3);
            }
        }
    }
}
