using System;
using System.Threading;

namespace ToyStore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Static data
            double puzzlePrice = 2.60;
            double dollPrice = 3.00;
            double bearPrice = 4.10;
            double minionPrice = 8.20;
            double truckPrice = 2.00;

            //Input
            double prize = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());
            int bear = int.Parse(Console.ReadLine());
            int minion = int.Parse(Console.ReadLine());
            int truck = int.Parse(Console.ReadLine());
            //Calculations
            int totalCount = puzzle + doll + bear + minion + truck;
            double totalMoney = puzzle * puzzlePrice + doll * dollPrice + bear * bearPrice + minion * minionPrice + truck * truckPrice;
            if (totalCount>=50)
            {
                totalMoney *= 0.75;
                totalMoney *= 0.9;
                if (prize <= totalMoney)
                {
                    double change = totalMoney - prize;
                    Console.WriteLine($"Yes! {change:F2} lv left.");
                }
                else
                {
                    double change = prize - totalMoney;
                    Console.WriteLine($"Not enough money! {change:F2} lv needed.");
                }
            }
            else
            {
                totalMoney *= 0.9;
                if (prize<totalMoney)
                {
                    double change = totalMoney - prize;
                    Console.WriteLine($"Yes! {change:F2} lv left.");
                }
                else
                {
                    double change = prize - totalMoney;
                    Console.WriteLine($"Not enough money! {change:F2} lv needed.");
                }
            }
        }
    }
}
