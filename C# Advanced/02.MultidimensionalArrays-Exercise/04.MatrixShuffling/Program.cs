using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixDimensions = Console.ReadLine()
                                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse)
                                            .ToArray();
            int rows = matrixDimensions[0];
            int cols = matrixDimensions[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] rowData = Console.ReadLine()
                                          .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] commandInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = commandInfo[0];

                bool isValidCommand = command == "swap" &&
                                      commandInfo.Length == 5;

                if (!isValidCommand)
                {
                    Console.WriteLine("Invalid input!");
                    input = Console.ReadLine();
                    continue;
                }

                int row1 = int.Parse(commandInfo[1]);
                int col1 = int.Parse(commandInfo[2]);
                int row2 = int.Parse(commandInfo[3]);
                int col2 = int.Parse(commandInfo[4]);

                bool isValidIndexes = row1 >= 0 && row1 < rows &&
                                      col1 >= 0 && col1 < cols &&
                                      row2 >= 0 && row2 < rows &&
                                      col2 >= 0 && col2 < cols;
                if (isValidIndexes)
                {
                    string currentCell = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = currentCell;

                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                input = Console.ReadLine();
            }
        }

        static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
