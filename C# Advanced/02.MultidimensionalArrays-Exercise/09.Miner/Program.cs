using System;
using System.Linq;

namespace _09.Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            string[] minerMoves = Console.ReadLine()
                                         .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            char[,] field = new char[fieldSize, fieldSize];

            int startRow = 0;
            int startCol = 0;
            int coals = 0;

            for (int row = 0; row < fieldSize; row++)
            {
                char[] rowData = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .Select(char.Parse)
                                        .ToArray();

                for (int col = 0; col < fieldSize; col++)
                {
                    field[row, col] = rowData[col];

                    if (rowData[col] == 's')
                    {
                        startRow = row;
                        startCol = col;
                    }
                    else if (rowData[col] == 'c')
                    {
                        coals++;
                    }
                }
            }

            for (int i = 0; i < minerMoves.Length; i++)
            {
                switch (minerMoves[i])
                {
                    case "left":
                        if (startCol > 0)
                        {
                            startCol--;
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "right":
                        if (startCol < fieldSize - 1)
                        {
                            startCol++;
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "up":
                        if (startRow > 0)
                        {
                            startRow--;
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "down":
                        if (startRow < fieldSize - 1)
                        {
                            startRow++;
                        }
                        else
                        {
                            continue;
                        }
                        break;
                }

                if (field[startRow, startCol] == 'c')
                {
                    coals--;
                    field[startRow, startCol] = '*';

                    if (coals == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({startRow}, {startCol})");
                        return;
                    }
                }
                else if (field[startRow, startCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({startRow}, {startCol})");
                    return;
                }
            }

            Console.WriteLine($"{coals} coals left. ({startRow}, {startCol})");
        }
    }
}
