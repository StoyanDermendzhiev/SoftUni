using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SugarCubes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sugarCubes = Console.ReadLine()
                                          .Split()
                                          .Select(int.Parse)
                                          .ToList();
            string input = Console.ReadLine();

            while (input != "Mort")
            {
                string[] command = input.Split();
                string currentCommand = command[0];
                int value = int.Parse(command[1]);

                if (currentCommand == "Add")
                {
                    sugarCubes.Add(value);
                }
                else if (currentCommand == "Remove")
                {
                    sugarCubes.Remove(value);
                }
                else if (currentCommand == "Replace")
                {
                    int replacement = int.Parse(command[2]);
                    int index = sugarCubes.IndexOf(value);
                    sugarCubes[index] = replacement;
                }
                else if (currentCommand == "Collapse")
                {
                    sugarCubes.RemoveAll(x => x < value);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", sugarCubes));
        }
    }
}
