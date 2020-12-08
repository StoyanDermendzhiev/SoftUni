using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.Santa_sSecretHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            
            string message = Console.ReadLine();

            string pattern = @"@(?<name>[A-Za-z]+)([^@\-!:>]+)!(?<behavior>[G|N])!";
            Regex regex = new Regex(pattern);

            var sb = new StringBuilder();

            while (message != "end")
            {
                string decryptedMessage = string.Empty;

                foreach (char ch in message)
                {
                    decryptedMessage += (char)(ch - key);
                }

                Match match = regex.Match(decryptedMessage);

                if (match.Success && match.Groups["behavior"].Value == "G")
                {
                    sb.AppendLine(match.Groups["name"].Value);
                }

                message = Console.ReadLine();
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
