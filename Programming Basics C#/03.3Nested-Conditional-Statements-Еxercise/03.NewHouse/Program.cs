using System;

namespace _03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string flower = Console.ReadLine();
            int flowersNumber = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            //Calculations
            double flowerPrice = 0;
            double discount = 1;
            switch (flower)
            {
                case "Roses":
                    flowerPrice = 5;
                    break;
                case "Dahlias":
                    flowerPrice = 3.80;
                    break;
                case "Tulips":
                    flowerPrice = 2.80;
                    break;
                case "Narcissus":
                    flowerPrice = 3;
                    break;
                case "Gladiolus":
                    flowerPrice = 2.50;
                    break;
            }
            if (flower == "Roses" && flowersNumber > 80)
            {
                discount = 0.90;
            }
            else if ((flower == "Dahlias" && flowersNumber > 90) || (flower == "Tulips" && flowersNumber > 80))
            {
                discount = 0.85;
            }
            else if (flower == "Narcissus" && flowersNumber < 120)
            {
                discount = 1.15;
            }
            else if (flower == "Gladiolus" && flowersNumber < 80)
            {
                discount = 1.20;
            }
            double totalMoney = flowersNumber * flowerPrice * discount;
            if (budget >= totalMoney)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersNumber} {flower} and {budget - totalMoney:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalMoney - budget:f2} leva more.");
            }
        }
    }
}
