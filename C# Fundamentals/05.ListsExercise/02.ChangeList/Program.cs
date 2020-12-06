using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] currentCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (currentCommand[0])
                {
                    case "Delete":
                        numbers.RemoveAll(n => n == int.Parse(currentCommand[1]));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(currentCommand[2]), int.Parse(currentCommand[1]));
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
