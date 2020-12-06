using System;

namespace _05.KartRankList
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();

            int goldCardCount = 0;
            int silverCardCount = 0;
            int bronzeCardCount = 0;
            int minTime = int.MaxValue;
            string bestPlayer = "";

            while (playerName != "Finish")
            {
                int minutes = int.Parse(Console.ReadLine());
                int seconds = int.Parse(Console.ReadLine());
                int allSeconds = minutes * 60 + seconds;
                if (allSeconds < 55)
                {
                    goldCardCount++;
                }
                else if (allSeconds >= 55 && allSeconds <= 85)
                {
                    silverCardCount++;
                }
                else if (allSeconds > 85 && allSeconds <= 120)
                {
                    bronzeCardCount++;
                }
                if (allSeconds < minTime)
                {
                    minTime = allSeconds;
                    bestPlayer = playerName;
                }
                playerName = Console.ReadLine();
            }
            int minMinutes = minTime / 60;
            int minSeconds = minTime % 60;
            Console.WriteLine($"With {minMinutes} minutes and {minSeconds} seconds {bestPlayer} is the winner of the day!");
            Console.WriteLine($"Today's prizes are {goldCardCount} Gold {silverCardCount} Silver and {bronzeCardCount} Bronze cards!");
        }
    }
}
