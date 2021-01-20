using System;
using System.Linq;

namespace _08.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] rowData = Console.ReadLine()
                                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            string[] coordinatesData = Console.ReadLine()
                                              .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int bomb = 0; bomb < coordinatesData.Length; bomb++)
            {
                int[] bombCoordinates = coordinatesData[bomb].Split(",")
                                                             .Select(int.Parse)
                                                             .ToArray();
                int bombRow = bombCoordinates[0];
                int bombCol = bombCoordinates[1];
                int bombPower = matrix[bombRow, bombCol];

                if (bombPower <= 0)
                {
                    continue;
                }

                for (int row = bombRow - 1; row <= bombRow + 1; row++)
                {
                    for (int col = bombCol - 1; col <= bombCol + 1; col++)
                    {
                        bool isValid = row >= 0 && row < n && col >= 0 && col < n;

                        if (isValid)
                        {
                            if (matrix[row, col] <= 0)
                            {
                                continue;
                            }

                            matrix[row, col] -= bombPower;
                        }
                    }
                }
                
            }

            int aliveCells = 0;
            int sum = 0;

            foreach (var cell in matrix)
            {
                if (cell > 0)
                {
                    aliveCells++;
                    sum += cell;
                }
            }

            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
