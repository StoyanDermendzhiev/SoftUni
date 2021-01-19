using System;
using System.Linq;

namespace _03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixDimensions = Console.ReadLine()
                                            .Split()
                                            .Select(int.Parse)
                                            .ToArray();
            int n = matrixDimensions[0];
            int m = matrixDimensions[1];

            int[,] matrix = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                int[] rowData = Console.ReadLine()
                                            .Split()
                                            .Select(int.Parse)
                                            .ToArray();

                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            int maxSum = 0;
            int maxSumRow = -1;
            int maxSumCol = -1;

            if (n > 2 && m > 2)
            {
                for (int row = 0; row < n - 2; row++)
                {
                    for (int col = 0; col < m - 2; col++)
                    {
                        int sum = 0;

                        for (int i = row; i < row + 3; i++)
                        {
                            for (int j = col; j < col + 3; j++)
                            {
                                sum += matrix[i, j];
                            }
                        }

                        if (sum > maxSum)
                        {
                            maxSum = sum;
                            maxSumRow = row;
                            maxSumCol = col;
                        }
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int i = maxSumRow; i < maxSumRow + 3; i++)
            {
                for (int j = maxSumCol; j < maxSumCol + 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
