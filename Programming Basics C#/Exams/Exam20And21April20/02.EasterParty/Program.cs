using System;

namespace _02.EasterParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestsNumber = int.Parse(Console.ReadLine());
            double passPrice = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            if (guestsNumber >= 10 && guestsNumber <= 15)
            {
                passPrice -= passPrice * 0.15;
            }
            else if (guestsNumber > 15 && guestsNumber <= 20)
            {
                passPrice -= passPrice * 0.20;
            }
            else if (guestsNumber > 20)
            {
                passPrice -= passPrice * 0.25;
            }
            double cakePrice = budget * 0.1;
            double totalMoney = guestsNumber * passPrice + cakePrice;
            if (totalMoney <= budget)
            {
                Console.WriteLine($"It is party time! {budget-totalMoney:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {totalMoney-budget:f2} leva needed.");
            }
        }
    }
}
