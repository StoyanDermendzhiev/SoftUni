using System;
using System.Text.RegularExpressions;

namespace _06.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            string pattern = @"([A-Za-z]*[0-9]*[\.\-_]?[A-za-z]*[0-9]*)@([A-za-z]*[\-]?[A-za-z]*\.[A-za-z]+[\-]?[A-za-z]+){1,}";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(inputLine);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        
        }
    }
}
