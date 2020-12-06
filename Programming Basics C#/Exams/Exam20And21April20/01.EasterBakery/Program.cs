using System;

namespace _01.EasterBakery
{
    class Program
    {
        static void Main(string[] args)
        {
            double flourPricePeriKilo = double.Parse(Console.ReadLine());
            double flourKilo = double.Parse(Console.ReadLine());
            double sugarKilo = double.Parse(Console.ReadLine());
            int eggsPacks = int.Parse(Console.ReadLine());
            int yeastPacks = int.Parse(Console.ReadLine());
            double sugarPricePerKilo = flourPricePeriKilo * 0.75;
            double eggsPackPrice = flourPricePeriKilo * 1.1;
            double yeastPackPrice = sugarPricePerKilo * 0.2;
            double totalMoney = flourPricePeriKilo * flourKilo + sugarPricePerKilo * sugarKilo + eggsPackPrice * eggsPacks + yeastPackPrice * yeastPacks;
            Console.WriteLine($"{totalMoney:f2}");
        }
    }
}
