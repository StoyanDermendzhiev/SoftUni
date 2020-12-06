using System;

namespace _06.BasketballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string tournamentName = Console.ReadLine();
            int allWinMatches = 0;
            int allMatchNumber = 0;

            while (tournamentName != "End of tournaments")
            {
                int matchNumber = int.Parse(Console.ReadLine());
                for (int match = 1; match <= matchNumber; match++)
                {
                    int pointsDesiTeam = int.Parse(Console.ReadLine());
                    int pointsOpponentTeam = int.Parse(Console.ReadLine());
                    int diff = 0;
                    if (pointsDesiTeam > pointsOpponentTeam)
                    {
                        allWinMatches++;
                        diff = pointsDesiTeam - pointsOpponentTeam;
                        Console.WriteLine($"Game {match} of tournament {tournamentName}: win with {diff} points.");
                    }
                    else if (pointsDesiTeam < pointsOpponentTeam)
                    {
                        diff = pointsOpponentTeam - pointsDesiTeam;
                        Console.WriteLine($"Game {match} of tournament {tournamentName}: lost with {diff} points.");
                    }
                }
                allMatchNumber += matchNumber;
                tournamentName = Console.ReadLine();
            }
            double percentWinMatches = 1.0 * allWinMatches / allMatchNumber * 100;
            double percentLostMatches = 100 - percentWinMatches;
            Console.WriteLine($"{percentWinMatches:f2}% matches win");
            Console.WriteLine($"{percentLostMatches:f2}% matches lost");
        }
    }
}
