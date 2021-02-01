using System;
using System.Linq;

namespace _01.ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Action<string[]> printNames = names => 
            Console.WriteLine(string.Join(Environment.NewLine, names));

            printNames(names);
        }
    }
}
