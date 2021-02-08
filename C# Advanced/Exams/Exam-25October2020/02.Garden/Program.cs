using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                                     .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            int[,] garden = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    garden[row, col] = 0;
                }
            }

            List<int[]> flowersCoordinates = new List<int[]>();

            string command = Console.ReadLine();

            while (command != "Bloom Bloom Plow")
            {
                int[] flowerCoordinates = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                 .Select(int.Parse)
                                                 .ToArray();
                int currFlowerRow = flowerCoordinates[0];
                int currFlowerCol = flowerCoordinates[1];
                bool isValidCoordinates = currFlowerRow >= 0 && currFlowerRow < n &&
                                          currFlowerCol >= 0 && currFlowerCol < m;

                if (!isValidCoordinates)
                {
                    Console.WriteLine("Invalid coordinates.");
                    command = Console.ReadLine();
                    continue;
                }

                flowersCoordinates.Add(flowerCoordinates);

                command = Console.ReadLine();
            }

            foreach (var flower in flowersCoordinates)
            {
                for (int i = 0; i < n; i++)
                {
                    garden[i, flower[1]]++;
                }

                for (int j = 0; j < m; j++)
                {
                    if (j != flower[1])
                    {
                        garden[flower[0], j]++;
                    }
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write(garden[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
