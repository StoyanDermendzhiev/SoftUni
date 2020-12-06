using System;

namespace _01.TheHuntingGames
{
    class Program
    {
        static void Main(string[] args)
        {
            int adventureDays = int.Parse(Console.ReadLine());
            int playersCount = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double waterPerDayForPerson = double.Parse(Console.ReadLine());
            double foodPerDayForPerson = double.Parse(Console.ReadLine());

            double totalWater = waterPerDayForPerson * playersCount * adventureDays;
            double totalFood = foodPerDayForPerson * playersCount * adventureDays;

            for (int day = 1; day <= adventureDays; day++)
            {
                double energyLoss = double.Parse(Console.ReadLine());

                groupEnergy -= energyLoss;

                if (groupEnergy <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
                    return;
                }

                if (day % 2 == 0)
                {
                    groupEnergy += groupEnergy * 0.05;
                    totalWater -= totalWater * 0.3;
                }

                if (day % 3 == 0)
                {
                    groupEnergy *= 1.10;
                    totalFood -= totalFood / playersCount;
                }
            }

            Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:f2} energy!");
        }
    }
}
