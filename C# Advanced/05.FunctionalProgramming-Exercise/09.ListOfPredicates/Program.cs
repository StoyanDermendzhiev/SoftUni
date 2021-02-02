using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            List<int> numbers = new List<int>();

            Func<int, int, bool> predicate = (num, div) => num % div == 0;

            for (int i = 1; i <= n; i++)
            {
                if (dividers.All(d => predicate(i, d)))
                {
                    numbers.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
