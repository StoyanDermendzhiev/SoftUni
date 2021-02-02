using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();

            while (input != "Party!")
            {
                string[] commandInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = commandInfo[0];
                string criteria = commandInfo[1];
                string comparer = commandInfo[2];

                Predicate<string> predicate = GetPredicate(criteria, comparer);

                if (command == "Remove")
                {
                    people.RemoveAll(predicate);
                }
                else if (command == "Double")
                {
                    var matches = people.FindAll(predicate);

                    if (matches.Count > 0)
                    {
                        int index = people.FindIndex(predicate);
                        people.InsertRange(index, matches);
                    }
                }

                input = Console.ReadLine();
            }

            if (people.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static Predicate<string> GetPredicate(string criteria, string comparer)
        {
            switch (criteria)
            {
                case "StartsWith":
                    return name => name.StartsWith(comparer);
                case "EndsWith":
                    return name => name.EndsWith(comparer);
                case "Length":
                    return name => name.Length == int.Parse(comparer);
                default:
                    throw new ArgumentException("Invalid command");
            }
        }
    }
}
