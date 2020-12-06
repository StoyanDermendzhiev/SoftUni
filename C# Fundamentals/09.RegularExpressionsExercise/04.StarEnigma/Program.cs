using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int messagesNumber = int.Parse(Console.ReadLine());

            string starPattern = @"[starSTAR]";
            string decryptedPattern = @"@([A-za-z]+)[^@\-!:>]*:(\d+)[^@\-!:>]*!([AD])![^@\-!:>]*->(\d+)";

            Regex starRegex = new Regex(starPattern);
            Regex decryptedRegex = new Regex(decryptedPattern);

            List<string> atackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < messagesNumber; i++)
            {
                string message = Console.ReadLine();

                int starCount = starRegex.Matches(message).Count;
                string decryptedMessage = string.Empty;

                foreach (char ch in message)
                {
                    decryptedMessage += (char)(ch - starCount);
                }

                Match match = decryptedRegex.Match(decryptedMessage);

                if (match.Success)
                {
                    string planetName = match.Groups[1].Value;
                    char attackType = char.Parse(match.Groups[3].Value);

                    if (attackType == 'A')
                    {
                        atackedPlanets.Add(planetName);
                    }
                    else if (attackType == 'D')
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {atackedPlanets.Count}");

            if (atackedPlanets.Count != 0)
            {
                foreach (var planet in atackedPlanets.OrderBy(x=>x))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");

            if (destroyedPlanets.Count != 0)
            {
                foreach (var planet in destroyedPlanets.OrderBy(x => x))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }
        }
    }
}
