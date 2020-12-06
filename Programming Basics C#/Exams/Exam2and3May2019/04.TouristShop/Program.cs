using System;

namespace _04.TouristShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string productName = Console.ReadLine();
            int productCount = 0;
            double totalMoney = 0;

            while (productName != "Stop")
            {
                double productPrice = double.Parse(Console.ReadLine());
                productCount++;
                if (productCount % 3 == 0)
                {
                    productPrice *= 0.50;
                }
                budget -= productPrice;
                if (budget < 0)
                {
                    Console.WriteLine($"You don't have enough money!");
                    Console.WriteLine($"You need {Math.Abs(budget):f2} leva!");
                    return;
                }
                totalMoney += productPrice;
                productName = Console.ReadLine();
            }
            Console.WriteLine($"You bought {productCount} products for {totalMoney:f2} leva.");
        }
    }
}
