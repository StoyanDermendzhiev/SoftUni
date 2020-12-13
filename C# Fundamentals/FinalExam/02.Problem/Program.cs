using System;
using System.Text.RegularExpressions;

namespace _02.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            string pattern = @"^(\S+)>(?<first>\d{3})\|(?<second>[a-z]{3})\|(?<third>[A-Z]{3})\|(?<fourth>[^\>\<]{3})<\1$";
            Regex regex = new Regex(pattern);

            for (int i = 0; i < numberOfInputs; i++)
            {
                string password = Console.ReadLine();

                Match match = regex.Match(password);

                if (match.Success)
                {
                    string encryptedPassword = match.Groups["first"].Value +
                                               match.Groups["second"].Value +
                                               match.Groups["third"].Value +
                                               match.Groups["fourth"].Value;

                    Console.WriteLine($"Password: {encryptedPassword}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
