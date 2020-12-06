﻿using System;
using System.Text;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            string output = RepeatString(input, count);
            Console.WriteLine(output);
        }

        private static string RepeatString(string input, int count)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                result.Append(input);
            }
            return result.ToString();
        }
    }
}
