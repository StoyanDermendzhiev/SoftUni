using System;
using System.Collections.Generic;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");

            var queue = new Queue<string>(songs);

            string input = Console.ReadLine();

            while (queue.Count > 0)
            {
                string[] commandInfo = input.Split();
                string command = commandInfo[0];

                if (command == "Play")
                {
                    queue.Dequeue();
                }
                else if (command == "Add")
                {
                    string song = input.Remove(0, command.Length + 1);
                    if (queue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(song);
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("No more songs!");
        }
    }
}
