using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _3.PostOffice
{
    class WordLenght
    {
        public WordLenght(int asciiIndex, int lenght)
        {
            AsciiIndex = asciiIndex;
            Lenght = lenght;
        }

        public int AsciiIndex { get; set; }
        public int Lenght { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|");

            string firstPart = input[0];
            string secondPart = input[1];
            string thirdPart = input[2];

            string firstPartPattern = @"([#\$%*&])([A-Z]+)\1";
            string secondPartPattern = @"(\d{2}):(\d{2})";
            string thirdPartPattern = @"\b[^\S]([A-Z]\S+)";

            Regex firstPartRegex = new Regex(firstPartPattern);
            Regex secondPartRegex = new Regex(secondPartPattern);
            Regex thirdPartRegex = new Regex(thirdPartPattern);

            MatchCollection firstPartMatches = firstPartRegex.Matches(firstPart);

            string capitalLetters = string.Empty;

            foreach (Match match in firstPartMatches)
            {
                capitalLetters += match.Value;
            }

            List<WordLenght> wordsLenghts = new List<WordLenght>();

            MatchCollection secondPartMatches = secondPartRegex.Matches(secondPart);

            foreach (Match match in secondPartMatches)
            {
                string[] arg = match.Value.Split(":");
                int asciiIndex = int.Parse(arg[0]);
                int lenght = int.Parse(arg[1]);

                WordLenght wordLenght = new WordLenght(asciiIndex, lenght);

                if (capitalLetters.Contains((char)asciiIndex))
                {
                    if (!wordsLenghts.Contains(wordLenght))
                    {
                        wordsLenghts.Add(wordLenght);
                    }
                }
            }

            MatchCollection thirdPartMatches = thirdPartRegex.Matches(thirdPart);

            foreach (Match match in thirdPartMatches)
            {
                string word = match.Groups[1].Value;

                foreach (var item in wordsLenghts)
                {
                    if (word.Length == item.Lenght + 1 && word.StartsWith((char)item.AsciiIndex))
                    {
                        Console.WriteLine(word);
                        break;
                    }
                }
            }
        }
    }
}
