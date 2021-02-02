using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Func<string, int, bool> filter = (name, n) =>
            {
                int sum = 0;

                foreach (char ch in name)
                {
                    sum += ch;
                }

                if (sum >= n)
                {
                    return true;
                }

                return false;
            };

            Func<List<string>, int, Func<string, int, bool>, string> result
                = (names, n, filter) => names.FirstOrDefault(name => filter(name, n));

            string name = result(names, n, filter);

            Console.WriteLine(name);
        }
    }
}
