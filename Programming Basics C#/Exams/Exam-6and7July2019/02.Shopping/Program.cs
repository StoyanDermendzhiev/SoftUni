using System;

namespace _02.Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videocard = int.Parse(Console.ReadLine());
            int cpu = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double videocardMoney = videocard * 250;
            double cpuPrice = videocardMoney * 0.35;
            double ramPrice = videocardMoney * 0.1;

            double totalMoney = videocardMoney + cpu * cpuPrice + ram * ramPrice;
            if (videocard > cpu)
            {
                totalMoney -= totalMoney * 0.15;
            }
            if (totalMoney <= budget)
            {
                Console.WriteLine($"You have {budget-totalMoney:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalMoney-budget:f2} leva more!");
            }
        }
    }
}
