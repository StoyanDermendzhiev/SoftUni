using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine()
                                  .Split()
                                  .Select(int.Parse)
                                  .ToArray();

            var queue = new Queue<int>(orders);

            Console.WriteLine(queue.Max().ToString());

            while (foodQuantity >= queue.Peek())
            {
                foodQuantity -= queue.Dequeue();

                if (queue.Count == 0)
                {
                    Console.WriteLine("Orders complete");
                    return;
                }
            }

            var sb = new StringBuilder();

            while (queue.Count > 0)
            {
                sb.Append($"{queue.Dequeue()} ");
            }

            Console.WriteLine($"Orders left: {sb}");
        }
    }
}
