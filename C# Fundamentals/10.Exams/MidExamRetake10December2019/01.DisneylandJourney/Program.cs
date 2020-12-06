using System;

namespace _01.DisneylandJourney
{
    class Program
    {
        static void Main(string[] args)
        {
            double journeyPrice = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());

            double totalMoney = 0;

            for (int currentMonth = 1; currentMonth <= months; currentMonth++)
            {
                if (currentMonth % 2 != 0 && currentMonth != 1)
                {
                    totalMoney -= totalMoney * 0.16;
                }

                if (currentMonth % 4 == 0)
                {
                    totalMoney += totalMoney * 0.25;
                }

                totalMoney += journeyPrice * 0.25;
            }

            if (totalMoney >= journeyPrice)
            {
                double moneyLeft = totalMoney - journeyPrice;
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {moneyLeft:f2}lv. for souvenirs.");
            }
            else
            {
                double moneyNeeded = journeyPrice - totalMoney;
                Console.WriteLine($"Sorry. You need {moneyNeeded:f2}lv. more.");
            }
        }
    }
}
