using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> contests = new Dictionary<string, Dictionary<string, int>>();

            while (input != "no more time")
            {
                string[] inputLine = input.Split(" -> ");
                string userName = inputLine[0];
                string contest = inputLine[1];
                int points = int.Parse(inputLine[2]);

                if (contests.ContainsKey(contest))
                {
                    if (contests[contest].ContainsKey(userName))
                    {
                        if (contests[contest][userName] < points)
                        {
                            contests[contest][userName] = points;
                        }
                    }
                    else
                    {
                        contests[contest].Add(userName, points);
                    }
                }
                else
                {
                    contests.Add(contest, new Dictionary<string, int>());
                    contests[contest].Add(userName, points);
                }

                input = Console.ReadLine();
            }

            Dictionary<string, List<int>> individualStatistics = new Dictionary<string, List<int>>();
            
            foreach (var contest in contests)
            {
                foreach (var user in contest.Value)
                {
                    if (individualStatistics.ContainsKey(user.Key))
                    {
                        individualStatistics[user.Key].Add(user.Value);
                    }
                    else
                    {
                        individualStatistics.Add(user.Key, new List<int> {user.Value});
                    }
                }
            }

            foreach (var contest in contests)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");

                int userCount = 0;

                foreach (var user in contest.Value.OrderByDescending(x=>x.Value)
                                                  .ThenBy(x=>x.Key))
                {
                    userCount++;
                    Console.WriteLine($"{userCount}. {user.Key} <::> {user.Value}");
                }
            }

            Console.WriteLine("Individual standings:");

            int individualCount = 0;

            foreach (var user in individualStatistics.OrderByDescending(x=>x.Value.Sum())
                                                     .ThenBy(x=>x.Key))
            {
                individualCount++;
                Console.WriteLine($"{individualCount}. {user.Key} -> {user.Value.Sum()}");
            }
        }
    }
}