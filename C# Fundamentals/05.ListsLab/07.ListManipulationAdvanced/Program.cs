using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ListManipulationAdvanced
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
            bool isChanged = false;

            while (command != "end")
            {
                string[] currentCommand = command.Split();

                switch (currentCommand[0])
                {
                    case "Add":
                        integers.Add(int.Parse(currentCommand[1]));
                        isChanged = true;
                        break;
                    case "Remove":
                        integers.Remove(int.Parse(currentCommand[1]));
                        isChanged = true;
                        break;
                    case "RemoveAt":
                        integers.RemoveAt(int.Parse(currentCommand[1]));
                        isChanged = true;
                        break;
                    case "Insert":
                        integers.Insert(int.Parse(currentCommand[2]), int.Parse(currentCommand[1]));
                        isChanged = true;
                        break;
                    case "Contains":
                        Console.WriteLine(integers.Contains(int.Parse(currentCommand[1])) ? "Yes" : "No such number");
                        break;
                    case "PrintEven":
                        Console.WriteLine(string.Join(" ", integers.Where(n => n % 2 == 0)));
                        break;
                    case "PrintOdd":
                        Console.WriteLine(string.Join(" ", integers.Where(n => n % 2 != 0)));
                        break;
                    case "GetSum":
                        Console.WriteLine(integers.Sum());
                        break;
                    case "Filter":
                        switch (currentCommand[1])
                        {
                            case "<":
                                Console.WriteLine(string.Join(" ", integers.Where(n => n < int.Parse(currentCommand[2]))));
                                break;
                            case ">":
                                Console.WriteLine(string.Join(" ", integers.Where(n => n > int.Parse(currentCommand[2]))));
                                break;
                            case ">=":
                                Console.WriteLine(string.Join(" ", integers.Where(n => n >= int.Parse(currentCommand[2]))));
                                break;
                            case "<=":
                                Console.WriteLine(string.Join(" ", integers.Where(n => n <= int.Parse(currentCommand[2]))));
                                break;
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", integers));
            }
        }
    }
}
