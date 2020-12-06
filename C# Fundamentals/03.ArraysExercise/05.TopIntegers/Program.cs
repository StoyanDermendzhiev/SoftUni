using System;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                                .Split(" ")
                                .Select(int.Parse)
                                .ToArray();
            bool isBigger = true;

            for (int i = 0; i < input.Length; i++)
            {
                int currentInt = input[i];

                for (int j = i + 1; j < input.Length; j++)
                {
                    int element = input[j];

                    if (element >= currentInt)
                    {
                        isBigger = false;
                        break;
                    }
                }
                if (isBigger)
                {
                    Console.Write(currentInt + " ");
                }
                isBigger = true;
            }
        }
    }
}
