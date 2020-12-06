using System;
using System.Collections.Generic;

namespace _01.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            Dictionary<char, int> symbolsCount = new Dictionary<char, int>();

            foreach (char symbol in inputString)
            {
                if (symbol != ' ')
                {
                    if (symbolsCount.ContainsKey(symbol))
                    {
                        symbolsCount[symbol]++;
                    }
                    else
                    {
                        symbolsCount.Add(symbol, 1);
                    }
                }
            }

            foreach (var symbol in symbolsCount)
            {
                Console.WriteLine($"{symbol.Key} -> {symbol.Value}");
            }
        }
    }
}
