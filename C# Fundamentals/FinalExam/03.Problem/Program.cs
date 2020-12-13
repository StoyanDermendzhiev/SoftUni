using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputCommand = Console.ReadLine();

            Dictionary<string, int> followers = new Dictionary<string, int>();

            while (inputCommand != "Log out")
            {
                string[] command = inputCommand.Split(": ");
                string currentCommand = command[0];
                string username = command[1];

                if (currentCommand == "New follower")
                {
                    if (!followers.ContainsKey(username))
                    {
                        followers.Add(username, 0);
                    }
                }
                else if (currentCommand == "Like")
                {
                    int count = int.Parse(command[2]);

                    if (!followers.ContainsKey(username))
                    {
                        followers.Add(username, count);
                    }
                    else
                    {
                        followers[username] += count;
                    }
                }
                else if (currentCommand == "Comment")
                {
                    if (!followers.ContainsKey(username))
                    {
                        followers.Add(username, 1);
                    }
                    else
                    {
                        followers[username] += 1;
                    }
                }
                else if (currentCommand == "Blocked")
                {
                    if (followers.ContainsKey(username))
                    {
                        followers.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"{username} doesn't exist.");
                    }
                }

                inputCommand = Console.ReadLine();
            }

            Console.WriteLine($"{followers.Count} followers");

            foreach (var follower in followers.OrderByDescending(x => x.Value)
                                              .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{follower.Key}: {follower.Value}");
            }
        }
    }
}