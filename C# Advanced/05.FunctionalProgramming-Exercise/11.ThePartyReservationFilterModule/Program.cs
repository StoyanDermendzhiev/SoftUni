using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.ThePartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();

            List<string> filters = new List<string>();

            while (input != "Print")
            {
                string[] commandInfo = input.Split(";");
                string command = commandInfo[0];
                string filterType = commandInfo[1];
                string filterParameter = commandInfo[2];

                if (command == "Add filter")
                {
                    filters.Add(filterType + " " + filterParameter);
                }
                else if (command == "Remove filter")
                {
                    filters.Remove(filterType + " " + filterParameter); ;
                }

                input = Console.ReadLine();
            }

            foreach (var filter in filters)
            {
                var commands = filter.Split(' ');

                if (commands[0] == "Starts")
                {
                    names = names.Where(p => !p.StartsWith(commands[2])).ToList();
                }
                else if (commands[0] == "Ends")
                {
                    names = names.Where(p => !p.EndsWith(commands[2])).ToList();
                }
                else if (commands[0] == "Length")
                {
                    names = names.Where(p => p.Length != int.Parse(commands[1])).ToList();
                }
                else if (commands[0] == "Contains")
                {
                    names = names.Where(p => !p.Contains(commands[1])).ToList();
                }
            }

            if (names.Any())
            {
                Console.WriteLine(string.Join(" ", names));
            }
        }
                    }
}
