using System;

namespace _04.Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            string sector = Console.ReadLine();
            int totalPoints = 301;
            int goodShotsCount = 0;
            int badShotsCount = 0;

            while (sector != "Retire")
            {
                int points = int.Parse(Console.ReadLine());
                goodShotsCount++;
                if (sector == "Double")
                {
                    points *= 2;
                }
                else if (sector == "Triple")
                {
                    points *= 3;
                }
                totalPoints -= points;

                if (totalPoints < 0)
                {
                    totalPoints += points;
                    goodShotsCount--;
                    badShotsCount++;
                }
                else if (totalPoints == 0)
                {
                    Console.WriteLine($"{playerName} won the leg with {goodShotsCount} shots.");
                    return;
                }
                sector = Console.ReadLine();
            }
            Console.WriteLine($"{playerName} retired after {badShotsCount} unsuccessful shots.");
        }
    }
}
