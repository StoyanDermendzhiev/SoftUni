using System;

namespace _02.FamilyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double nightPrice = double.Parse(Console.ReadLine());
            int percentAdditionalCosts = int.Parse(Console.ReadLine());

            if (nights > 7)
            {
                nightPrice -= nightPrice * 0.05;
            }
            double totalMoney = nights * nightPrice + budget * percentAdditionalCosts / 100;
            if (totalMoney <= budget)
            {
                Console.WriteLine($"Ivanovi will be left with {budget-totalMoney:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{totalMoney-budget:f2} leva needed.");
            }
        }
    }
}
