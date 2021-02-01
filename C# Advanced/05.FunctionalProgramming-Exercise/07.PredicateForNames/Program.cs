using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Func<List<string>, List<string>> filter = names =>
            {
                names = names.Where(name => name.Length <= 4).ToList();

                return names;
            };

            Console.WriteLine(string.Join(Environment.NewLine, filter(names)));
        }
    }
}
