using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, int> students = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            while (input != "exam finished")
            {
                string[] currentLine = input.Split("-");

                if (currentLine[1] == "banned")
                {
                    students.Remove(currentLine[0]);
                }
                else
                {
                    string userName = currentLine[0];
                    string language = currentLine[1];
                    int points = int.Parse(currentLine[2]);

                    if (students.ContainsKey(userName))
                    {
                        if (points > students[userName])
                        {
                            students[userName] = points;
                        }
                    }
                    else
                    {
                        students.Add(userName, points);
                    }

                    if (submissions.ContainsKey(language))
                    {
                        submissions[language] += 1;
                    }
                    else
                    {
                        submissions.Add(language, 1);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Results:");
            foreach (var student in students.OrderByDescending(x => x.Value)
                                            .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }

            Console.WriteLine($"Submissions:");
            foreach (var submission in submissions.OrderByDescending(x => x.Value)
                                                  .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{submission.Key} - {submission.Value}");
            }
        }
    }
}

