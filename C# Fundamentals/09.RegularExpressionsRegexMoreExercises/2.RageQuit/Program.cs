using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _2.RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();

            string pattern = @"(\D+)(\d+)";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(inputData);

            var uniqueSymbols = new StringBuilder();
            var resultString = new StringBuilder();

            foreach (Match match in matches)
            {
                int repeatedTimes = int.Parse(match.Groups[2].Value);

                if (repeatedTimes != 0)
                {
                    string matchString = match.Groups[1].Value.ToUpper();

                    for (int i = 0; i < matchString.Length; i++)
                    {
                        if (!uniqueSymbols.ToString().Contains(matchString[i]))
                        {
                            uniqueSymbols.Append(matchString[i]);
                        }
                    }

                    for (int i = 0; i < repeatedTimes; i++)
                    {
                        resultString.Append(matchString);
                    }
                }
            }

            Console.WriteLine($"Unique symbols used: {uniqueSymbols.ToString().Length}");
            Console.WriteLine(resultString.ToString().Trim());
        }
    }
}
