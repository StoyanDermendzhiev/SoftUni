using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToList();

            int n = int.Parse(Console.ReadLine());

            Predicate<int> isDivisible = num => num % n == 0;

            numbers.RemoveAll(isDivisible);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
