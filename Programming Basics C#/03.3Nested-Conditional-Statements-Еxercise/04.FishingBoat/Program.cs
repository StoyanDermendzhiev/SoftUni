using System;

namespace _04.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());
            //Calculations
            double boatPrice = 0;
            double discount = 0;
            switch (season)
            {
                case "Spring":
                    boatPrice = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    boatPrice = 4200;
                    break;
                case "Winter":
                    boatPrice = 2600;
                    break;
            }
            if (fishermen <= 6)
            {
                discount = 0.1;
            }
            else if (fishermen >= 7 && fishermen <= 11)
            {
                discount = 0.15;
            }
            else if (fishermen >= 12)
            {
                discount = 0.25;
            }
            double totalPrice = boatPrice - boatPrice * discount;
            if (fishermen % 2 == 0 && season != "Autumn")
            {
                totalPrice = totalPrice - totalPrice * 0.05;
            }
            if (budget >= totalPrice)
            {
                Console.WriteLine($"Yes! You have {budget-totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice-budget:f2} leva.");
            }
        }
    }
}
