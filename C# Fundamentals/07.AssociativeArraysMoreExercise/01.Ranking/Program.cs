using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            string inputContest = Console.ReadLine();

            while (inputContest != "end of contests")
            {
                string[] contestData = inputContest.Split(":");
                string contest = contestData[0];
                string password = contestData[1];

                contests.Add(contest, password);

                inputContest = Console.ReadLine();
            }

            Dictionary<string, Dictionary<string, int>> submissions = new Dictionary<string, Dictionary<string, int>>();
            string inputSubmission = Console.ReadLine();

            while (inputSubmission != "end of submissions")
            {
                string[] submissionData = inputSubmission.Split("=>");
                string contest = submissionData[0];
                string password = submissionData[1];
                string userName = submissionData[2];
                int points = int.Parse(submissionData[3]);

                bool contestIsValid = contests.ContainsKey(contest);

                if (contestIsValid == false)
                {
                    inputSubmission = Console.ReadLine();
                    continue;
                }

                bool passwordIsCorrect = contests[contest] == password;

                if (passwordIsCorrect == false)
                {
                    inputSubmission = Console.ReadLine();
                    continue;
                }

                if (contestIsValid && passwordIsCorrect)
                {
                    bool isSameContestAndUser = submissions.ContainsKey(userName) &&
                                                submissions[userName].ContainsKey(contest);

                    if (isSameContestAndUser)
                    {
                        if (submissions[userName][contest] < points)
                        {
                            submissions[userName][contest] = points;
                        }
                    }
                    else if (submissions.ContainsKey(userName))
                    {
                        submissions[userName].Add(contest, points);
                    }
                    else
                    {
                        submissions.Add(userName, new Dictionary<string, int>());
                        submissions[userName].Add(contest, points);
                    }
                }

                inputSubmission = Console.ReadLine();
            }

            Dictionary<string, int> totalPoints = new Dictionary<string, int>();

            foreach (var user in submissions)
            {
                int maxPoints = 0;

                foreach (var contest in user.Value)
                {
                    maxPoints += contest.Value;
                }

                totalPoints.Add(user.Key, maxPoints);
            }

            string bestUser = totalPoints.OrderByDescending(x => x.Value).First().Key;
            int bestUserPoints = totalPoints.OrderByDescending(x => x.Value).First().Value;

            Console.WriteLine($"Best candidate is {bestUser} with total {bestUserPoints} points.");
            Console.WriteLine($"Ranking: ");

            foreach (var user in submissions.OrderBy(x => x.Key))
            {
                Console.WriteLine(user.Key);

                foreach (var contest in user.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
