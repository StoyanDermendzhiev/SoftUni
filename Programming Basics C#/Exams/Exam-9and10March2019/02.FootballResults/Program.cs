using System;

namespace _02.FootballResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstResult = Console.ReadLine();
            string secondResult = Console.ReadLine();
            string thirdResult = Console.ReadLine();
            int wonCount = 0;
            int lostCount = 0;
            int drawnCount = 0;

            if (firstResult[0] > firstResult[2])
            {
                wonCount++;
            }
            else if (firstResult[0] == firstResult[2])
            {
                drawnCount++;
            }
            else
            {
                lostCount++;
            }
            if (secondResult[0] > secondResult[2])
            {
                wonCount++;
            }
            else if (secondResult[0] == secondResult[2])
            {
                drawnCount++;
            }
            else
            {
                lostCount++;
            }
            if (thirdResult[0] > thirdResult[2])
            {
                wonCount++;
            }
            else if (thirdResult[0] == thirdResult[2])
            {
                drawnCount++;
            }
            else
            {
                lostCount++;
            }
            Console.WriteLine($"Team won {wonCount} games.");
            Console.WriteLine($"Team lost {lostCount} games.");
            Console.WriteLine($" Drawn games: {drawnCount}");

        }
    }
}
