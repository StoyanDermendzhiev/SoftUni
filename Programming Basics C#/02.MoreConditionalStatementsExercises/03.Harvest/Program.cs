using System;
using System.Security.Cryptography.X509Certificates;

namespace _03.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Static data
            double grapeForLitreWine = 2.5;
            //Input
            int grapeArea = int.Parse(Console.ReadLine());
            double harvestGrape = double.Parse(Console.ReadLine());
            int wineNeeded = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            //Calculations
            double grapeAreaForWine = grapeArea * 0.4;
            double totalWine = (grapeAreaForWine * harvestGrape) / grapeForLitreWine;
            if (totalWine < wineNeeded)
            {
                double moreWineNeed = Math.Floor(wineNeeded - totalWine);
                Console.WriteLine($"It will be a tough winter! More {moreWineNeed} liters wine needed.");
            }
            else
            {
                double wineLeft = totalWine - wineNeeded;
                double winePerWorker = wineLeft / workers;
                Math.Ceiling(wineLeft);
                Math.Ceiling(winePerWorker);
                Math.Floor(totalWine);
                Console.WriteLine($"Good harvest this year! Total wine: {totalWine} liters.");
                Console.WriteLine($"{wineLeft} liters left -> {winePerWorker} liters per person.");
            }
        }
    }
}
