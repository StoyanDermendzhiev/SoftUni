using System;

namespace _02.Godzillavs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int actorNumber = int.Parse(Console.ReadLine());
            double clothesPrice = double.Parse(Console.ReadLine());

            double decorPrice = budget * 0.1;

            if (actorNumber > 150)
            {
                clothesPrice -= clothesPrice * 0.1;
            }

            double totalMoney = decorPrice + actorNumber * clothesPrice;

            if (totalMoney <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalMoney:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalMoney - budget:f2} leva more.");
            }
        }
    }
}
