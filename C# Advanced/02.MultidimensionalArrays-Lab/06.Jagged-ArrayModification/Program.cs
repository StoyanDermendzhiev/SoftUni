using System;
using System.Linq;

namespace _06.Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] matrix = new int[n][];

            for (int row = 0; row < n; row++)
            {
                int[] rowData = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToArray();
                matrix[row] = new int[rowData.Length]; 

                for (int col = 0; col < rowData.Length; col++)
                {
                    matrix[row][col] = rowData[col];
                }
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                var splitted = command.Split();
                string currentCommand = splitted[0];
                int row = int.Parse(splitted[1]);
                int col = int.Parse(splitted[2]);
                int value = int.Parse(splitted[3]);

                if (row >= 0 && col >= 0 && row < n && col < n)
                {
                    if (currentCommand == "Add")
                    {
                        matrix[row][col] += value;
                    }
                    else if (currentCommand == "Subtract")
                    {
                        matrix[row][col] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }

                command = Console.ReadLine();
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
