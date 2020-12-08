using System;
using System.Text.RegularExpressions;

namespace _04.MorseCodeUpgraded
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] codedMessage = Console.ReadLine()
                                           .Split('|');

            string zeroPattern = @"0{2,}";
            string onePattern = @"1{2,}";

            Regex zeroRegex = new Regex(zeroPattern);
            Regex oneRegex = new Regex(onePattern);

            string decipheredMessage = string.Empty;

            foreach (string part in codedMessage)
            {
                MatchCollection zeroMatches = zeroRegex.Matches(part);
                MatchCollection oneMatches = oneRegex.Matches(part);

                int sequencesPoints = 0;

                foreach (Match match in zeroMatches)
                {
                    sequencesPoints += match.Value.Length;
                }

                foreach (Match match in oneMatches)
                {
                    sequencesPoints += match.Value.Length;
                }

                int zeroCount = 0;
                int oneCount = 0;
                
                for (int i = 0; i < part.Length; i++)
                {
                    if (part[i] == '0')
                    {
                        zeroCount++;
                    }
                    else if (part[i] == '1')
                    {
                        oneCount++;
                    }
                }

                char letter = (char)(zeroCount * 3 + oneCount * 5 + sequencesPoints);
                decipheredMessage += letter.ToString();
            }

            Console.WriteLine(decipheredMessage);
        }
    }
}
