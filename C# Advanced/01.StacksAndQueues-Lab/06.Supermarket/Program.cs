using System;
using System.Collections.Generic;
using System.Text;

namespace _06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();
            string input = Console.ReadLine();

            var sb = new StringBuilder();

            while (input != "End")
            {
                if (input == "Paid")
                {
                    while (queue.Count > 0)
                    {
                        sb.AppendLine(queue.Dequeue());
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            sb.AppendLine($"{queue.Count} people remaining.");

            Console.WriteLine(sb.ToString());
        }
    }
}
