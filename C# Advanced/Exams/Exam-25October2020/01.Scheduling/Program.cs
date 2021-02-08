using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> tasks = new Stack<int>(Console.ReadLine()
                                                     .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                                     .Select(int.Parse));
            Queue<int> threads = new Queue<int>(Console.ReadLine()
                                                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                     .Select(int.Parse));
            int killedValue = int.Parse(Console.ReadLine());

            while (threads.Count > 0)
            {
                int currThread = threads.Peek();
                int currTask = tasks.Peek();

                if (currTask == killedValue)
                {
                    Console.WriteLine($"Thread with value {currThread} killed task {killedValue}");
                    break;
                }

                if (currThread >= currTask)
                {
                    tasks.Pop();
                }

                threads.Dequeue();
            }

            Console.WriteLine(string.Join(" ", threads));
        }
    }
}
