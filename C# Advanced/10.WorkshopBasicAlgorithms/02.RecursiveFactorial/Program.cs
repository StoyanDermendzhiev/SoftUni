﻿using System;

namespace _02.RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long result = Factorial(n);

            Console.WriteLine(result);
        }

        public static long Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }
    }
}
