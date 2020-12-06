using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> neighborhood = Console.ReadLine()
                                            .Split("@")
                                            .Select(int.Parse)
                                            .ToList();
            string input = Console.ReadLine();
            int lenght = 0;

            while (input != "Love!")
            {
                string[] command = input
                                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                  .ToArray();
                int currentLenght = int.Parse(command[1]);

                if (lenght + currentLenght > neighborhood.Count -1)
                {
                    currentLenght = 0;
                    lenght = 0;
                }
                lenght += currentLenght;

                if (neighborhood[lenght] == 0)
                {
                    Console.WriteLine($"Place {lenght} already had Valentine's day.");
                }
                else
                {
                    neighborhood[lenght] = neighborhood[lenght] - 2;

                    if (neighborhood[lenght] == 0)
                    {
                        Console.WriteLine($"Place {lenght} has Valentine's day.");
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {lenght}.");

            int houseCount = 0;

            for (int i = 0; i < neighborhood.Count; i++)
            {
                if (neighborhood[i] != 0)
                {
                    houseCount++;
                }
            }

            if (houseCount != 0)
            {
                Console.WriteLine($"Cupid has failed {houseCount} places.");
            }
            else
            {
                Console.WriteLine("Mission was successful.");
            }
        }
    }
}
