using System;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] knights = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(knight => $"Sir {knight}")
                .ToArray();

            Action<string[]> printKnights = names =>
            Console.WriteLine(string.Join(Environment.NewLine, names));

            printKnights(knights);
        }
    }
}
