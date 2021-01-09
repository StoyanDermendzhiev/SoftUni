using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                                 .Split();
            var elements = Console.ReadLine()
                                  .Split()
                                  .Select(int.Parse)
                                  .ToArray();

            int s = int.Parse(numbers[1]);
            int x = int.Parse(numbers[2]);

            var stack = new Stack<int>(elements);

            for (int i = 0; i < s; i++)
            {
                if (stack.Count == 0)
                {
                    break;
                }
                stack.Pop();
            }

            if (stack.Count != 0)
            {
                if (stack.Contains(x))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
