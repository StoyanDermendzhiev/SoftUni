using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"(\||#)(?<itemName>[A-za-z\ ]+)\1(?<expirationDate>[0-9]{2}\/[0-9]{2}\/[0-9]{2})\1(?<calories>[0-9]{1,5})\1";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            int totalCalories = 0;
            var sb = new StringBuilder();

            foreach (Match match in matches)
            {
                totalCalories += int.Parse(match.Groups["calories"].Value);
                sb.AppendLine($"Item: {match.Groups["itemName"].Value}, Best before: {match.Groups["expirationDate"].Value}, Nutrition: {match.Groups["calories"].Value}");
            }

            int days = totalCalories / 2000;

            Console.WriteLine($"You have food to last you for: {days} days!");
            Console.WriteLine(sb.ToString());
        }
    }
}
