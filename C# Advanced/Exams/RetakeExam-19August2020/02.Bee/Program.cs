using System;

namespace _02.Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] territory = new char[n, n];

            int beeRow = 0;
            int beeCol = 0;

            for (int row = 0; row < n; row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    territory[row, col] = rowData[col];

                    if (territory[row, col] == 'B')
                    {
                        beeRow = row;
                        beeCol = col;
                    }
                }
            }

            int pollinatedFlowers = 0;
            bool isBeeInTerritory = true;
            string command = Console.ReadLine();

            while (command != "End")
            {
                territory[beeRow, beeCol] = '.';

                switch (command)
                {
                    case "up":
                        beeRow--;
                        break;
                    case "down":
                        beeRow++;
                        break;
                    case "left":
                        beeCol--;
                        break;
                    case "right":
                        beeCol++;
                        break;
                }

                bool isValidIndex = beeRow >= 0 && beeRow < n &&
                                    beeCol >= 0 && beeCol < n;

                if (!isValidIndex)
                {
                    Console.WriteLine("The bee got lost!");
                    isBeeInTerritory = false;
                    break;
                }
                 
                if (territory[beeRow, beeCol] == 'f')
                {
                    pollinatedFlowers++;
                }
                else if (territory[beeRow, beeCol] == 'O')
                {
                    territory[beeRow, beeCol] = '.';
                    continue;
                }

                command = Console.ReadLine();
            }

            if (pollinatedFlowers >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {pollinatedFlowers} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - pollinatedFlowers} flowers more");
            }

            if (isBeeInTerritory)
            {
                territory[beeRow, beeCol] = 'B';
            }

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
