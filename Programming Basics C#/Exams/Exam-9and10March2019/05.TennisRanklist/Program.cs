using System;

namespace _05.TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamentNumber = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            int winPoints = 0;
            int tournamentWinCount = 0;
            for (int i = 1; i <= tournamentNumber; i++)
            {
                string stage = Console.ReadLine();
                if (stage == "W")
                {
                    winPoints += 2000;
                    tournamentWinCount++;
                }
                else if (stage == "F")
                {
                    winPoints += 1200;
                }
                else if (stage == "SF")
                {
                    winPoints += 720;
                }
            }
            int finalPoints = winPoints + startingPoints;
            double averagePoints = Math.Floor(1.0 * winPoints / tournamentNumber);
            double percentTournamentsWon = 1.0 * tournamentWinCount / tournamentNumber * 100;

            Console.WriteLine($"Final points: {finalPoints}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{percentTournamentsWon:f2}% ");
        }
    }
}
