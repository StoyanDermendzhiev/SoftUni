using System;

namespace GodzillaKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int actor = int.Parse(Console.ReadLine());
            double clothesprice = double.Parse(Console.ReadLine());
            double decor = budget * 0.1;
            if (actor>150)
            {
                clothesprice *= 0.9;
            }
            double finalPriceForClothes = clothesprice*actor;
            double finalMoney = decor + finalPriceForClothes;
            if (finalMoney<=budget)
            {
                double moneyLeft = budget - finalMoney;
                Console.WriteLine("Äction!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
            else
            {
                double needMoney = finalMoney - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {needMoney:f2} leva more.");
            }
        }
    }
}
