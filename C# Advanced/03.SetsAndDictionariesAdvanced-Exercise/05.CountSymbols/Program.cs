using System;
using System.Collections.Generic;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            SortedDictionary<char, int> countChars = new SortedDictionary<char, int>();

            foreach (char ch in text)
            {
                if (!countChars.ContainsKey(ch))
                {
                    countChars.Add(ch, 0);
                }

                countChars[ch]++;
            }

            foreach (var item in countChars)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
