using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string places = Console.ReadLine();
            List<string> validLocations = new List<string>();

            string pattern = @"(=|\/)(?<location>[A-Z][A-Za-z]{2,})\1";
            Regex regex = new Regex(pattern);
            MatchCollection validPlaces = regex.Matches(places);

            int sum = 0;

            if (validPlaces.Count > 0)
            {
                foreach (Match place in validPlaces)
                {
                    validLocations.Add(place.Groups["location"].Value);
                    sum += place.Groups["location"].Length;
                }
            }

            Console.WriteLine($"Destinations: {string.Join(", ", validLocations)}");
            Console.WriteLine($"Travel Points: {sum}");
        }
    }
}

