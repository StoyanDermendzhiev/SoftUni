using System;
using System.Collections.Generic;

namespace _02.Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] territory = new char[n, n];

            int snakeRow = 0;
            int snakeCol = 0;

            List<string> lair = new List<string>();

            for (int row = 0; row < n; row++)
            {
                string rowData = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    territory[row, col] = rowData[col];

                    if (territory[row, col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                    }
                    else if (territory[row, col] == 'B')
                    {
                        lair.Add($"{row}{col}");
                    }
                }
            }

            int foodEaten = 0;

            while (true)
            {
                string command = Console.ReadLine();

                territory[snakeRow, snakeCol] = '.';

                switch (command)
                {
                    case "up":
                        snakeRow--;
                        break;
                    case "down":
                        snakeRow++;
                        break;
                    case "left":
                        snakeCol--;
                        break;
                    case "right":
                        snakeCol++;
                        break;
                }

                bool isOut = snakeRow >= n || snakeRow < 0 ||
                             snakeCol >= n || snakeCol < 0;

                if (isOut)
                {
                    Console.WriteLine("Game over!");
                    break;
                }

                if (territory[snakeRow, snakeCol] == 'B')
                {
                    territory[snakeRow, snakeCol] = '.';
                    string currSnakeCoordinates = $"{snakeRow}{snakeCol}";
                    string newSnakeCoordinates = lair.Find(l => l != currSnakeCoordinates);

                    snakeRow = int.Parse(newSnakeCoordinates[0].ToString());
                    snakeCol = int.Parse(newSnakeCoordinates[1].ToString());

                    territory[snakeRow, snakeCol] = 'S';
                }
                else if (territory[snakeRow, snakeCol] == '*')
                {
                    territory[snakeRow, snakeCol] = 'S';
                    foodEaten++;
                }

                if (foodEaten >= 10)
                {
                    Console.WriteLine("You won! You fed the snake.");
                    break;
                }
            }

            Console.WriteLine($"Food eaten: {foodEaten}");

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(territory[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
