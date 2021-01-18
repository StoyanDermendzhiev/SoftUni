using System;
using System.Linq;

namespace _05.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputData = Console.ReadLine()
                                     .Split(", ")
                                     .Select(int.Parse)
                                     .ToArray();
            int rows = inputData[0];
            int cols = inputData[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine()
                                     .Split(", ")
                                     .Select(int.Parse)
                                     .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            int maxSum = 0;
            int maxSumRow = 0;
            int maxSumCol = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    int squareSum = matrix[row, col] + matrix[row, col + 1] + 
                                    matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (squareSum > maxSum)
                    {
                        maxSum = squareSum;
                        maxSumRow = row;
                        maxSumCol = col;
                    }
                }
            }

            for (int row = maxSumRow; row < maxSumRow + 2; row++)
            {
                for (int col = maxSumCol; col < maxSumCol + 2; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}
