using System;
using System.Linq;

namespace _01.SumMatrixElements
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

            Console.WriteLine(rows);
            Console.WriteLine(cols);

            int sum = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    sum += matrix[row, col];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
