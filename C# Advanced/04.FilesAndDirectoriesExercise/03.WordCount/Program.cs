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
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach (var word in File.ReadAllLines("words.txt"))
            {
                wordsCount.Add(word, 0);
            }

            string pattern = @"[A-Za-z']+";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(File.ReadAllText("text.txt"));

            foreach (Match match in matches)
            {
                if (wordsCount.ContainsKey(match.Value.ToLower()))
                {
                    wordsCount[match.Value.ToLower()]++;
                }
            }

            File.WriteAllLines("../../../actualResult.txt", wordsCount.Select(x => x.Key + " - " + x.Value));
        }
    }
}
