using System;

namespace _06.TournamentOfChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamentDays = int.Parse(Console.ReadLine());
            double totalDayMoney = 0;
            double totalMoney = 0;
            int winCount = 0;
            int loseCount = 0;
            int totalWin = 0;
            int totalLose = 0;
            for (int i = 1; i <= tournamentDays; i++)
            {
                string sport = Console.ReadLine();
                winCount = 0;
                loseCount = 0;
                totalDayMoney = 0;
                while (sport != "Finish")
                {
                    string winOrLose = Console.ReadLine();
                    if (winOrLose == "win")
                    {
                        winCount++;
                        totalDayMoney += 20;
                    }
                    else
                    {
                        loseCount++;
                    }
                    sport = Console.ReadLine();
                }
                if (winCount > loseCount)
                {
                    totalDayMoney *= 1.1;
                }
                totalWin += winCount;
                totalLose += loseCount;
                totalMoney += totalDayMoney;
            }
            if (totalWin > totalLose)
            {
                totalMoney *= 1.2;
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoney:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:f2}");
            }
        }
    }
}
