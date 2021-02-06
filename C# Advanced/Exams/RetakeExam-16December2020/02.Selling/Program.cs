using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] bakery = new char[n, n];
            List<string> pillars = new List<string>();

            int bakerRow = 0;
            int bakerCol = 0;

            for (int row = 0; row < n; row++)
            {
                char[] rowData = Console.ReadLine()
                                        .ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    bakery[row, col] = rowData[col];

                    if (bakery[row, col] == 'S')
                    {
                        bakerRow = row;
                        bakerCol = col;
                    }

                    if (bakery[row, col] == 'O')
                    {
                        pillars.Add($"{row}{col}");
                    }
                }
            }

            int sum = 0;
            bool isNotValidIndex = false;

            while (!isNotValidIndex && sum < 50)
            {
                string command = Console.ReadLine();
                bakery[bakerRow, bakerCol] = '-';

                switch (command)
                {
                    case "up":
                        bakerRow--;
                        break;
                    case "down":
                        bakerRow++;
                        break;
                    case "left":
                        bakerCol--;
                        break;
                    case "right":
                        bakerCol++;
                        break;
                }

                isNotValidIndex = bakerRow < 0 || bakerRow == n || bakerCol < 0 || bakerCol == n;

                if (isNotValidIndex)
                {
                    Console.WriteLine("Bad news, you are out of the bakery.");
                    continue;
                }

                if (Char.IsDigit(bakery[bakerRow, bakerCol]))
                {
                    sum += int.Parse(bakery[bakerRow, bakerCol].ToString());
                }
                else if (bakery[bakerRow, bakerCol] == 'O')
                {
                    bakery[bakerRow, bakerCol] = '-';

                    string otherPillarCoordinates = pillars.Where(p => p != $"{bakerRow}{bakerCol}").FirstOrDefault();

                    bakerRow = int.Parse(otherPillarCoordinates[0].ToString());
                    bakerCol = int.Parse(otherPillarCoordinates[1].ToString());
                }

                if (sum >= 50)
                {
                    bakery[bakerRow, bakerCol] = 'S';
                    Console.WriteLine("Good news! You succeeded in collecting enough money!");
                    continue;
                }
            }

            Console.WriteLine($"Money: {sum}");

            for (int row = 0; row < bakery.GetLength(0); row++)
            {
                for (int col = 0; col < bakery.GetLength(1); col++)
                {
                    Console.Write($"{bakery[row, col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
