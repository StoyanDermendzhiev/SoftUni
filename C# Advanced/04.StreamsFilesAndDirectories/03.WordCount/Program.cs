using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] getWords = File.ReadAllText("../../../words.txt").Split();
            Dictionary<string, int> words = new Dictionary<string, int>();

            string pattern = @"[A-Za-z']+";
            Regex regex = new Regex(pattern);

            string[] lines = File.ReadLines("../../../text.txt").ToArray();

            for (int i = 0; i < lines.Length; i++)
            {
                MatchCollection matches = regex.Matches(lines[i]);

                foreach (Match match in matches)
                {
                    if (getWords.Contains(match.Value.ToLower()))
                    {
                        if (!words.ContainsKey(match.Value.ToLower()))
                        {
                            words.Add(match.Value.ToLower(), 1);
                        }
                        else
                        {
                            words[match.Value.ToLower()]++;
                        }
                    }
                }
            }

            using (StreamWriter streamWriter = new StreamWriter("../../../Output.txt"))
            {
                foreach (var item in words.OrderByDescending(x => x.Value))
                {
                    streamWriter.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
    }
}
