using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<string> mirrorPairs = new List<string>();

            string pattern = @"([@|#])(?<first>[A-Za-z]{3,})\1\1(?<second>[A-Za-z]{3,})\1";

            Regex regex = new Regex(pattern);
            MatchCollection wordPairs = regex.Matches(text);

            if (wordPairs.Count > 0)
            {

                foreach (Match match in wordPairs)
                {
                    string word1 = match.Groups["first"].Value;
                    string mirrorWord = match.Groups["second"].Value;
                    string word2 = string.Empty;

                    for (int i = mirrorWord.Length - 1; i >= 0; i--)
                    {
                        word2 += mirrorWord[i];
                    }

                    if (word1 == word2)
                    {
                        string mirrorPair = word1 + " <=> " + mirrorWord;
                        mirrorPairs.Add(mirrorPair);
                    }
                }

                Console.WriteLine($"{wordPairs.Count} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }

            if (mirrorPairs.Count > 0)
            {
                Console.WriteLine("The mirror words are:");
            }
            else
            {
                Console.WriteLine($"No mirror words!");
                return;
            }

            Console.WriteLine(string.Join(", ", mirrorPairs));
        }
    }
}
