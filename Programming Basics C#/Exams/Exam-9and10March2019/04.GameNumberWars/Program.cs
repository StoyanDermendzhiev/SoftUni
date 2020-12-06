using System;

namespace _04.GameNumberWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string player1 = Console.ReadLine();
            string player2 = Console.ReadLine();
            string input = Console.ReadLine();
            int player1Points = 0;
            int player2Points = 0;
            string winner = "";
            int winnerPoints = 0;

            while (input != "End of game")
            {
                int cardPlayer1 = int.Parse(input);
                int cardPlayer2 = int.Parse(Console.ReadLine());

                if (cardPlayer1 > cardPlayer2)
                {
                    player1Points += cardPlayer1 - cardPlayer2;
                }
                else if (cardPlayer2 > cardPlayer1)
                {
                    player2Points += cardPlayer2 - cardPlayer1;
                }
                else
                {
                    cardPlayer1 = int.Parse(Console.ReadLine());
                    cardPlayer2 = int.Parse(Console.ReadLine());
                    if (cardPlayer1 > cardPlayer2)
                    {
                        winnerPoints = player1Points;
                        winner = player1;
                    }
                    else if (cardPlayer2 > cardPlayer1)
                    {
                        winnerPoints = player2Points;
                        winner = player2;
                    }
                    Console.WriteLine("Number wars!");
                    Console.WriteLine($"{winner} is winner with {winnerPoints} points");
                    return;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{player1} has {player1Points} points");
            Console.WriteLine($"{player2} has {player2Points} points");

        }
    }
}
