using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02.EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string coolThresholdPattern = @"[0-9]";
            string emojiPattern = @"(\*\*|\:\:)([A-Z][a-z]{2,})\1";

            Regex coolThresholdRegex = new Regex(coolThresholdPattern);
            MatchCollection coolThresholdMatches = coolThresholdRegex.Matches(text);

            BigInteger coolThreshold = 1;

            foreach (Match ch in coolThresholdMatches)
            {
                coolThreshold *= int.Parse(ch.ToString());
            }

            Regex emojiRegex = new Regex(emojiPattern);
            MatchCollection emojiMathces = emojiRegex.Matches(text);

            List<string> coolEmojis = new List<string>();

            foreach (Match emoji in emojiMathces)
            {
                BigInteger coolnes = 0;

                foreach (char ch in emoji.Value)
                {
                    if (ch != ':' && ch != '*')
                    {
                        coolnes += ch;
                    }
                }

                if (coolnes > coolThreshold)
                {
                    coolEmojis.Add(emoji.Value);
                }
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{emojiMathces.Count} emojis found in the text. The cool ones are:");

            if (coolEmojis.Count > 0)
            {
                foreach (string emoji in coolEmojis)
                {
                    Console.WriteLine(emoji);
                }
            }
        }
    }
}
