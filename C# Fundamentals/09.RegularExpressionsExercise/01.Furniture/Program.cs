using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @">>(\w+)<<(\d+\.?\d+)!(\d+)";

            Regex regex = new Regex(pattern);

            double totalSum = 0;

            var sb = new StringBuilder();

            sb.AppendLine("Bought furniture:");

            while (input != "Purchase")
            {
                if (regex.IsMatch(input))
                {
                    Match furniture = regex.Match(input);

                    double price = double.Parse(furniture.Groups[2].ToString());
                    int quantity = int.Parse(furniture.Groups[3].ToString());

                    totalSum += price * quantity;

                    sb.AppendLine($"{furniture.Groups[1]}");
                }

                input = Console.ReadLine();
            }

            sb.AppendLine($"Total money spend: {totalSum:f2}");

            Console.WriteLine(sb.ToString());
        }
    }
}
