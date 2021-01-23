using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, string> contests = new Dictionary<string, string>();

            while (input != "end of contests")
            {
                string[] contestData = input.Split(":");
                if (contestData.Length == 2)
                {
                    contests.Add(contestData[0], contestData[1]);
                }

                input = Console.ReadLine();
            }

            string sumbission = Console.ReadLine();

            SortedDictionary<string, Dictionary<string, int>> users = new SortedDictionary<string, Dictionary<string, int>>();

            while (sumbission != "end of submissions")
            {
                string[] userData = sumbission.Split("=>");
                string contestName = userData[0];
                string password = userData[1];

                if (contests.ContainsKey(contestName) && contests[contestName] == password)
                {
                    string username = userData[2];
                    int points = int.Parse(userData[3]);

                    if (!users.ContainsKey(username))
                    {
                        users.Add(username, new Dictionary<string, int>());
                        users[username].Add(contestName, points);
                    }

                    if (users[username].ContainsKey(contestName))
                    {
                        if (users[username][contestName] < points)
                        {
                            users[username][contestName] = points;
                        }
                    }
                    else
                    {
                        users[username].Add(contestName, points);
                    }
                }

                sumbission = Console.ReadLine();
            }

            int maxTotalPoints = 0;
            string bestCandidate = string.Empty;

            foreach (var user in users)
            {
                int totalPoints = user.Value.Values.Sum();

                if (maxTotalPoints < totalPoints)
                {
                    maxTotalPoints = totalPoints;
                    bestCandidate = user.Key;
                }
            }

            Console.WriteLine($"Best candidate is {bestCandidate} with total {maxTotalPoints} points.");
            Console.WriteLine("Ranking:");

            foreach (var user in users)
            {
                Console.WriteLine(user.Key);

                foreach (var contest in user.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
