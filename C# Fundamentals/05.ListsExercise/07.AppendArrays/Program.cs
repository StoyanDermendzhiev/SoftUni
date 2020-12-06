using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                            .Split("|")
                            .ToList();

            input.Reverse();

            List<string> output = new List<string>();

            foreach (string inputArr in input)
            {
                string[] values = inputArr
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                foreach (string element in values)
                {
                    output.Add(element);
                }
            }

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
