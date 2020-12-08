using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06.EmailStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int emailsCount = int.Parse(Console.ReadLine());

            string pattern = @"^([A-Za-z]{5,})@(([a-z]{3,}).(org|bg|com))$";
            Regex regex = new Regex(pattern);

            Dictionary<string, List<string>> domains = new Dictionary<string, List<string>>();

            for (int i = 0; i < emailsCount; i++)
            {
                string email = Console.ReadLine();

                Match match = regex.Match(email);

                if (match.Success)
                {
                    string domain = match.Groups[2].Value;
                    string user = match.Groups[1].Value;

                    if (domains.ContainsKey(domain))
                    {
                        if (!domains[domain].Contains(user))
                        {
                            domains[domain].Add(user);
                        }
                    }
                    else
                    {
                        domains.Add(domain, new List<string> { user });
                    }
                }
            }

            foreach (var currentDomain in domains.OrderByDescending(d=>d.Value.Count))
            {
                Console.WriteLine($"{currentDomain.Key}:");

                foreach (var user in currentDomain.Value)
                {
                    Console.WriteLine($"### {user}");
                }
            }
        }
    }
}
