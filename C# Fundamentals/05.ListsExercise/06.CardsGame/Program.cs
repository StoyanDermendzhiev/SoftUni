using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToList();
            List<int> secondPlayer = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToList();

            while (firstPlayer.Count != 0 && secondPlayer.Count != 0)
            {
                int firstPlayerCard = firstPlayer[0];
                int secondPlayerCard = secondPlayer[0];

                if (firstPlayerCard > secondPlayerCard)
                {
                    firstPlayer.Add(firstPlayerCard);
                    firstPlayer.Add(secondPlayerCard);
                }
                else if (firstPlayerCard < secondPlayerCard)
                {
                    secondPlayer.Add(secondPlayerCard);
                    secondPlayer.Add(firstPlayerCard);
                }

                firstPlayer.RemoveAt(0);
                secondPlayer.RemoveAt(0);
            }

            string player = string.Empty;
            int sum = 0;

            if (firstPlayer.Count == 0)
            {
                player = "Second";
                sum = secondPlayer.Sum();
            }
            else if (secondPlayer.Count == 0)
            {
                player = "First";
                sum = firstPlayer.Sum();
            }

            Console.WriteLine($"{player} player wins! Sum: {sum}");
        }
    }
}
