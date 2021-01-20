using System;

namespace _07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int n = int.Parse(Console.ReadLine());
                char[,] board = new char[n, n];

                for (int row = 0; row < n; row++) // read the board
                {
                    string currentRow = Console.ReadLine();
                    for (int col = 0; col < n; col++)
                    {
                        board[row, col] = currentRow[col];
                    }
                }

                int numberRemovedKnights = 0;

                while (true)
                {
                    int maxNumberAttackKnights = int.MinValue;
                    int rowMax = int.MinValue;
                    int colMax = int.MinValue;
                    for (int row = 0; row < board.GetLength(0); row++)
                    {
                        for (int col = 0; col < board.GetLength(1); col++)
                        {
                            int numberAttackKnights = 0;
                            if (board[row, col] == 'K')
                            {
                                numberAttackKnights = MethodToCheckInFrontOfTheKnight(n, board, row, col, numberAttackKnights);
                                numberAttackKnights = MethodToCheckBehindTheKnight(n, board, row, col, numberAttackKnights);
                                numberAttackKnights = MethodToCheckOnLeftTheKnight(n, board, row, col, numberAttackKnights);
                                numberAttackKnights = MethodToCheckOnRightTheKnight(n, board, row, col, numberAttackKnights);
                            }

                            if (numberAttackKnights > maxNumberAttackKnights)
                            {
                                maxNumberAttackKnights = numberAttackKnights;
                                rowMax = row;
                                colMax = col;
                            }
                        }
                    }

                    if (maxNumberAttackKnights > 0)
                    {
                        board[rowMax, colMax] = '0';
                        numberRemovedKnights++;
                    }

                    else if (maxNumberAttackKnights == 0)
                    {
                        break;
                    }
                }

                Console.WriteLine(numberRemovedKnights);
            }
        }
        private static int MethodToCheckOnRightTheKnight(int n, char[,] board, int row, int col, int numberAttackKnights)
        {
            if (row + 1 < n && col + 2 < n)
            {
                if (board[row + 1, col + 2] == 'K') // on right 
                {
                    numberAttackKnights++;
                }
            }

            if (row - 1 >= 0 && col + 2 < n)
            {
                if (board[row - 1, col + 2] == 'K')
                {
                    numberAttackKnights++;
                }
            }

            return numberAttackKnights;
        }

        private static int MethodToCheckOnLeftTheKnight(int n, char[,] board, int row, int col, int numberAttackKnights)
        {
            if (row + 1 < n && col - 2 >= 0)
            {
                if (board[row + 1, col - 2] == 'K') // on left 
                {
                    numberAttackKnights++;
                }
            }

            if (row - 1 >= 0 && col - 2 >= 0)
            {
                if (board[row - 1, col - 2] == 'K')
                {
                    numberAttackKnights++;
                }
            }

            return numberAttackKnights;
        }

        private static int MethodToCheckBehindTheKnight(int n, char[,] board, int row, int col, int numberAttackKnights)
        {
            if (row + 2 < n && col + 1 < n)
            {
                if (board[row + 2, col + 1] == 'K') // behind
                {
                    numberAttackKnights++;
                }
            }

            if (row + 2 < n && col - 1 >= 0)
            {
                if (board[row + 2, col - 1] == 'K')
                {
                    numberAttackKnights++;
                }
            }

            return numberAttackKnights;
        }

        private static int MethodToCheckInFrontOfTheKnight(int n, char[,] board, int row, int col, int numberAttackKnights)
        {
            if (row - 2 >= 0 && col + 1 < n)
            {
                if (board[row - 2, col + 1] == 'K') // in front of
                {
                    numberAttackKnights++;
                }
            }

            if (row - 2 >= 0 && col - 1 >= 0)
            {
                if (board[row - 2, col - 1] == 'K')
                {
                    numberAttackKnights++;
                }
            }

            return numberAttackKnights;
        }
    }
}
