using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("text.txt");

            string symbolPattern = @"[\w]";
            Regex symbolRegex = new Regex(symbolPattern);

            string punctuationPattern = @"[^\w\s]";
            Regex punctuationRegex = new Regex(punctuationPattern);

            for (int i = 0; i < lines.Length; i++)
            {
                int symbols = symbolRegex.Matches(lines[i]).Count;
                int punctuations = punctuationRegex.Matches(lines[i]).Count;

                lines[i] = $"Line {i + 1}: {lines[i]} ({symbols})({punctuations})";
            }

            File.WriteAllLines("../../../output.txt", lines);
        }
    }
}
