using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ArcheryTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> fieldTargets = Console.ReadLine()
                                            .Split("|")
                                            .Select(int.Parse)
                                            .ToList();
            string input = Console.ReadLine();
            int totalPoints = 0;

            while (input != "Game over")
            {
                string[] command = input.Split("@")
                                        .ToArray();

                string currentCommand = command[0];
                int shootingIndex = 0;

                if (currentCommand == "Shoot Left")
                {
                    int startIndex = int.Parse(command[1]);
                    int lenght = int.Parse(command[2]);
                    bool validStartIndex = startIndex >= 0 &&
                       startIndex <= fieldTargets.Count - 1;

                    if (validStartIndex)
                    {
                        shootingIndex = startIndex - lenght;

                        while (shootingIndex < 0)
                        {
                            shootingIndex = fieldTargets.Count + shootingIndex;
                        }

                        fieldTargets[shootingIndex] -= 5;

                        if (fieldTargets[shootingIndex] < 0)
                        {
                            fieldTargets[shootingIndex] = 0;
                        }

                        totalPoints += 5;
                    }
                }
                else if (currentCommand == "Shoot Right")
                {
                    int startIndex = int.Parse(command[1]);
                    int lenght = int.Parse(command[2]);
                    bool validStartIndex = startIndex >= 0 &&
                       startIndex <= fieldTargets.Count - 1;

                    if (validStartIndex)
                    {
                        shootingIndex = startIndex + lenght;

                        while (shootingIndex > fieldTargets.Count - 1)
                        {
                            shootingIndex = shootingIndex - fieldTargets.Count;
                        }

                        fieldTargets[shootingIndex] -= 5;

                        if (fieldTargets[shootingIndex] < 0)
                        {
                            fieldTargets[shootingIndex] = 0;
                        }

                        totalPoints += 5;
                    }
                }
                else if (currentCommand == "Reverse")
                {
                    fieldTargets.Reverse();
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" - ", fieldTargets));
            Console.WriteLine($"Iskren finished the archery tournament with {totalPoints} points!");
        }
    }
}
