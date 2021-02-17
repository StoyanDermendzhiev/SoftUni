using System;

namespace _02.Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int commandsNumber = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];
            int playerRow = 0;
            int playerCol = 0;

            for (int row = 0; row < n; row++)
            {
                string rowData = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowData[col];

                    if (matrix[row, col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            bool isFinished = false;

            for (int i = 0; i < commandsNumber; i++)
            {
                string command = Console.ReadLine();
                int newPlayerRow = playerRow;
                int newPlayerCol = playerCol;

                matrix[playerRow, playerCol] = '-';

                switch (command)
                {
                    case "up":
                        playerRow--;

                        if (playerRow < 0)
                        {
                            playerRow = n - 1;
                        }

                        if (matrix[playerRow, playerCol] == 'B')
                        {
                            playerRow--;

                            if (playerRow < 0)
                            {
                                playerRow = n - 1;
                            }
                        }

                        if (matrix[playerRow, playerCol] == 'T')
                        {
                            playerRow++;

                            if (playerRow == n)
                            {
                                playerRow = 0;
                            }
                        }
                        break;
                    case "down":
                        playerRow++;
                        if (playerRow == n)
                        {
                            playerRow = 0;
                        }

                        if (matrix[playerRow, playerCol] == 'B')
                        {
                            playerRow++;

                            if (playerRow == n)
                            {
                                playerRow = 0;
                            }
                        }

                        if (matrix[playerRow, playerCol] == 'T')
                        {
                            playerRow--;

                            if (playerRow < 0)
                            {
                                playerRow = n - 1;
                            }
                        }
                        break;
                    case "left":
                        playerCol--;
                        if (playerCol < 0)
                        {
                            playerCol = n - 1;
                        }

                        if (matrix[playerRow, playerCol] == 'B')
                        {
                            playerCol--;

                            if (playerCol < 0)
                            {
                                playerCol = n - 1;
                            }
                        }

                        if (matrix[playerRow, playerCol] == 'T')
                        {
                            playerCol++;

                            if (playerCol == n)
                            {
                                playerCol = 0;
                            }
                        }
                        break;
                    case "right":
                        playerCol++;

                        if (playerCol == n)
                        {
                            playerCol = 0;
                        }

                        if (matrix[playerRow, playerCol] == 'B')
                        {
                            playerCol++;

                            if (playerCol == n)
                            {
                                playerCol = 0;
                            }
                        }

                        if (matrix[playerRow, playerCol] == 'T')
                        {
                            playerCol--;

                            if (playerCol < 0)
                            {
                                playerCol = n - 1;
                            }
                        }
                        break;
                }

                if (matrix[playerRow, playerCol] == '-')
                {
                    matrix[playerRow, playerCol] = 'f';
                }

                if (matrix[playerRow, playerCol] == 'F')
                {
                    matrix[playerRow, playerCol] = 'f';
                    matrix[newPlayerRow, newPlayerCol] = '-';
                    isFinished = true;

                    Console.WriteLine("Player won!");
                    break;
                }
            }

            if (!isFinished)
            {
                Console.WriteLine("Player lost!");
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
