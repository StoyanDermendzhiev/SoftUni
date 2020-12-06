using System;

namespace _05.FootballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string footballTeamName = Console.ReadLine();
            int matchNumber = int.Parse(Console.ReadLine());

            if (matchNumber == 0)
            {
                Console.WriteLine($"{footballTeamName} hasn't played any games during this season.");
                return;
            }

            int countW = 0;
            int countD = 0;
            int countL = 0;
            int totalPoints = 0;

            for (int match = 1; match <= matchNumber; match++)
            {
                char result = char.Parse(Console.ReadLine());
                if (result == 'W')
                {
                    countW++;
                    totalPoints += 3;
                }
                else if (result == 'D')
                {
                    countD++;
                    totalPoints += 1;
                }
                else if (result == 'L')
                {
                    countL++;
                }
            }
            double winRate = 1.0 * countW / matchNumber * 100;

            Console.WriteLine($"{footballTeamName} has won {totalPoints} points during this season.");
            Console.WriteLine("Total stats:");
            Console.WriteLine($"## W: {countW}");
            Console.WriteLine($"## D: {countD}");
            Console.WriteLine($"## L: {countL}");
            Console.WriteLine($"Win rate: {winRate:f2}%");
        }
    }
}
