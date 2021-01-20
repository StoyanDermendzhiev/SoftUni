using System;
using System.Linq;

namespace _05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixDimensions = Console.ReadLine()
                                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse)
                                            .ToArray();
            string snake = Console.ReadLine();

            int n = matrixDimensions[0];
            int m = matrixDimensions[1];

            char[,] matrix = new char[n, m];

            int count = 0;

            for (int row = 0; row < n; row++)
            {
                                
                if (row % 2 == 0)
                {
                    for (int col = 0; col < m; col++)
                    {
                        if (count == snake.Length)
                        {
                            count = 0;
                        }

                        matrix[row, col] = snake[count];
                        count++;
                    }
                }
                else
                {
                    for (int col = m - 1; col >= 0; col--)
                    {
                        if (count == snake.Length)
                        {
                            count = 0;
                        }

                        matrix[row, col] = snake[count];
                        count++;
                    }
                }
            }

            PrintMatrix(matrix);
        }

        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
