using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
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

            while (command != "End")
            {
                string[] currentCommand = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (currentCommand[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(currentCommand[1]));
                        break;
                    case "Insert":
                        if (IsValidIndex(currentCommand[2], numbers))
                        {
                            numbers.Insert(int.Parse(currentCommand[2]), int.Parse(currentCommand[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Remove":
                        if (IsValidIndex(currentCommand[1], numbers))
                        {
                            numbers.RemoveAt(int.Parse(currentCommand[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Shift":
                        if (currentCommand[1] == "left")
                        {
                            for (int i = 0; i < int.Parse(currentCommand[2]); i++)
                            {
                                numbers.Add(numbers[0]);
                                numbers.RemoveAt(0);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < int.Parse(currentCommand[2]); i++)
                            {
                                numbers.Insert(0, numbers[numbers.Count - 1]);
                                numbers.RemoveAt(numbers.Count - 1);
                            }
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static bool IsValidIndex(string v, List<int> numbers)
        {
            int index = int.Parse(v);

            if ((index > numbers.Count - 1) || (index < 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
