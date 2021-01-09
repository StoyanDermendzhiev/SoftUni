using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

            Stack<int> stack = new Stack<int>(nums);

            string input = Console.ReadLine().ToLower();

            while (input != "end")
            {
                var command = input.Split();
                string currentCommand = command[0];
                int firstNumber = int.Parse(command[1]);

                if (currentCommand == "add")
                {
                    int secondNumber = int.Parse(command[2]);

                    stack.Push(firstNumber);
                    stack.Push(secondNumber);
                }
                else if (currentCommand == "remove")
                {
                    if (firstNumber <= stack.Count)
                    {
                        for (int i = 0; i < firstNumber; i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                input = Console.ReadLine().ToLower();
            }

            var sum = stack.Sum();

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
