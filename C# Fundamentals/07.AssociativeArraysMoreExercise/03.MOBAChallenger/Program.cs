using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MOBAChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> playerPool = new Dictionary<string, Dictionary<string, int>>();

            while (input != "Season end")
            {
                if (input.Contains(" -> "))
                {
                    string[] inputLine = input.Split(" -> ");
                    string player = inputLine[0];
                    string position = inputLine[1];
                    int skill = int.Parse(inputLine[2]);

                    if (playerPool.ContainsKey(player))
                    {
                        if (playerPool[player].ContainsKey(position))
                        {
                            if (playerPool[player][position] < skill)
                            {
                                playerPool[player][position] = skill;
                            }
                        }
                        else
                        {
                            playerPool[player].Add(position, skill);
                        }
                    }
                    else
                    {
                        playerPool.Add(player, new Dictionary<string, int>());
                        playerPool[player].Add(position, skill);
                    }
                }
                else if (input.Contains(" vs "))
                {
                    string[] inputLine = input.Split(" vs ");
                    string player1 = inputLine[0];
                    string player2 = inputLine[1];

                    if (playerPool.ContainsKey(player1) && playerPool.ContainsKey(player2))
                    {
                        string playerToRemove = string.Empty;

                        foreach (var positionP1 in playerPool[player1])
                        {
                            foreach (var positionP2 in playerPool[player2])
                            {
                                if (positionP1.Key == positionP2.Key)
                                {
                                    if (positionP1.Value < positionP2.Value)
                                    {
                                        playerToRemove = player1;
                                    }
                                    else if (positionP1.Value > positionP2.Value)
                                    {
                                        playerToRemove = player2;
                                    }
                                }
                            }
                        }

                        playerPool.Remove(playerToRemove);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var player in playerPool.OrderByDescending(x => x.Value.Values.Sum())
                                             .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {playerPool[player.Key].Values.Sum()} skill");

                foreach (var position in player.Value.OrderByDescending(x => x.Value)
                                                     .ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }
    }
}
