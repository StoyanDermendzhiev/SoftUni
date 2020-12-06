using System;

namespace _02.Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            const double petrolPrice = 2.10;
            const int guidePrice = 100;
            
            double budget = double.Parse(Console.ReadLine());
            double petrol = double.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            double totalMoney = petrolPrice * petrol + guidePrice;

            switch (dayOfWeek)
            {   
                case "Saturday":
                    totalMoney *= 0.90;
                    break;
                case "Sunday":
                    totalMoney *= 0.80;
                    break;
            }
            if (budget >= totalMoney)
            {
                Console.WriteLine($"Safari time! Money left: {budget - totalMoney:f2} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {totalMoney - budget:f2} lv.");
            }
        }
    }
}
