using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, List<string>> forceBook = new Dictionary<string, List<string>>();

            while (command != "Lumpawaroo")
            {
                string forceSide = string.Empty;
                string forceUser = string.Empty;

                if (command.Contains(" | "))
                {
                    string[] inputLine = command.Split(" | ");
                    forceSide = inputLine[0];
                    forceUser = inputLine[1];

                    bool containsUser = false;

                    foreach (var side in forceBook)
                    {
                        if (side.Value.Contains(forceUser))
                        {
                            containsUser = true;
                        }
                    }

                    if (forceBook.ContainsKey(forceSide))
                    {
                        if (containsUser == false)
                        {
                            forceBook[forceSide].Add(forceUser);
                        }
                    }
                    else
                    {
                        forceBook.Add(forceSide, new List<string>());
                        if (containsUser == false)
                        {
                            forceBook[forceSide].Add(forceUser);
                        }
                    }
                }
                else if (command.Contains(" -> "))
                {
                    string[] inputLine = command.Split(" -> ");
                    forceSide = inputLine[1];
                    forceUser = inputLine[0];

                    foreach (var item in forceBook)
                    {
                        if (item.Value.Contains(forceUser))
                        {
                            item.Value.Remove(forceUser);
                        }
                    }

                    if (!forceBook.ContainsKey(forceSide))
                    {
                        forceBook.Add(forceSide, new List<string>());
                    }

                    forceBook[forceSide].Add(forceUser);

                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }

                command = Console.ReadLine();
            }

            forceBook = forceBook.OrderByDescending(x => x.Value.Count)
                                 .ThenBy(x => x.Key)
                                 .ToDictionary(x => x.Key, x => x.Value);

            foreach (var side in forceBook)
            {
                if (side.Value.Count != 0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");

                    side.Value.Sort();

                    foreach (string user in side.Value)
                    {
                        Console.WriteLine($"! {user}");
                    }
                }
            }
        }
    }
}
