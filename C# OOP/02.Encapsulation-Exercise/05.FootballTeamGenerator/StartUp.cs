using System;
using System.Collections.Generic;

namespace _05.FootballTeamGenerator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var teams = new Dictionary<string, Team>();

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }

                string[] parts = line.Split(";", StringSplitOptions.RemoveEmptyEntries);
                string command = parts[0];

                try
                {
                    string teamName = parts[1];

                    if (command == "Add")
                    {

                        if (!teams.ContainsKey(teamName))
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                            continue;
                        }

                        string playerName = parts[2];
                        int endurance = int.Parse(parts[3]);
                        int sprint = int.Parse(parts[4]);
                        int dribble = int.Parse(parts[5]);
                        int passing = int.Parse(parts[6]);
                        int shooting = int.Parse(parts[7]);

                        teams[teamName].AddPlayer(new Player(playerName, endurance, sprint, dribble, passing, shooting));
                    }
                    else if (command == "Remove")
                    {
                        string playerName = parts[2];

                        teams[teamName].RemovePlayer(playerName);
                    }
                    else if (command == "Rating")
                    {
                        if (!teams.ContainsKey(teamName))
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                            continue;
                        }

                        Console.WriteLine($"{teamName} - {teams[teamName].Rating}");
                    }
                    else if (command == "Team")
                    {
                        if (!teams.ContainsKey(teamName))
                        {
                            teams.Add(teamName, new Team(teamName));
                        }
                    }
                }
                catch (Exception ex)
                when (ex is ArgumentException || ex is InvalidOperationException)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
