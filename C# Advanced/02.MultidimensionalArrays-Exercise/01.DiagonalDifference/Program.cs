using System;
using System.Linq;

namespace _01.DiagonalDifference
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
                                       .Split()
                                       .Select(int.Parse)
                                       .ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            int primDiagonalSum = 0;
            int secDiagonalSum = 0;

            for (int row = 0; row < n; row++)
            {
                primDiagonalSum += matrix[row, row];
                secDiagonalSum += matrix[row, n - 1 - row];
            }

            int diff = Math.Abs(primDiagonalSum - secDiagonalSum);

            Console.WriteLine(diff);
        }
    }
}
