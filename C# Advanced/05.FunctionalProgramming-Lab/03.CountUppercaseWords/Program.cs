using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Func<string, bool> checkIsUpper = n => char.IsUpper(n[0]);

            string[] words = text.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                 .Where(checkIsUpper)
                                 .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
