using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine()
                                           .Split(", ");
                                               
            Dictionary<string, int> racers = new Dictionary<string, int>();

            foreach (string participant in participants)
            {
                racers.Add(participant, 0);
            }

            string namePattern = @"[\W\d]";
            string numberPattern = @"[\WA-za-z]";

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string name = Regex.Replace(input, namePattern, "");
                string distance = Regex.Replace(input, numberPattern, "");

                int sum = 0;

                foreach (char digit in distance)
                {
                    sum += int.Parse(digit.ToString());
                }

                if (racers.ContainsKey(name))
                {
                    racers[name] += sum;
                }

                input = Console.ReadLine();
            }

            int count = 1;

            foreach (var racer in racers.OrderByDescending(x=>x.Value))
            {
                string textToPrint = count == 1 ? "st" : 
                                     count == 2 ? "nd" : "rd";

                Console.WriteLine($"{count++}{textToPrint} place: {racer.Key}");

                if (count == 4)
                {
                    break;
                }
            }
        }
    }
}
