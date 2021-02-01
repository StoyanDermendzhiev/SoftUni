using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            Func<int[], int[]> addFunc = numbers =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] += 1;
                }

                return numbers;
            };

            Func<int[], int[]> multiplyFunc = numbers =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] *= 2;
                }

                return numbers;
            };

            Func<int[], int[]> subtractFunc = numbers =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] -= 1;
                }

                return numbers;
            };

            Action<int[]> print = numbers => Console.WriteLine(string.Join(" ", numbers));

            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        addFunc(numbers);
                        break;
                    case "multiply":
                        multiplyFunc(numbers);
                        break;
                    case "subtract":
                        subtractFunc(numbers);
                        break;
                    case "print":
                        print(numbers);
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
