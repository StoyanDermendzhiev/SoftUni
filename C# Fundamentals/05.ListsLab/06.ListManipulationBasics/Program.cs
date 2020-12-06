using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] currentCommand = command.Split();

                switch (currentCommand[0])
                {
                    case "Add":
                        integers.Add(int.Parse(currentCommand[1]));
                        break;
                    case "Remove":
                        integers.Remove(int.Parse(currentCommand[1]));
                        break;
                    case "RemoveAt":
                        integers.RemoveAt(int.Parse(currentCommand[1]));
                        break;
                    case "Insert":
                        integers.Insert(int.Parse(currentCommand[2]), int.Parse(currentCommand[1]));
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", integers));
        }
    }
}
