using System;
using System.Linq;

namespace _02.SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixDimensions = Console.ReadLine()
                                            .Split()
                                            .Select(int.Parse)
                                            .ToArray();

            char[,] matrix = new char[matrixDimensions[0], matrixDimensions[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine()
                                            .Split()
                                            .Select(char.Parse)
                                            .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            int count = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    char symbol = matrix[row, col];

                    bool isEqual = matrix[row, col + 1] == symbol &&
                                   matrix[row + 1, col] == symbol &&
                                   matrix[row + 1, col + 1] == symbol;

                    if (isEqual)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
