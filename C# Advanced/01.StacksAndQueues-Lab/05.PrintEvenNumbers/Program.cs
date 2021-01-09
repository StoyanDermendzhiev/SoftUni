using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse)
                                 .ToArray();

            var queue = new Queue<int>();

            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    queue.Enqueue(num);
                }
            }

            while (queue.Count > 1)
            {
                Console.Write($"{queue.Dequeue()}, ");
            }

            Console.WriteLine(queue.Dequeue());
        }
    }
}
