using System;

namespace _11.HappyCatParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            int numberOfHours = int.Parse(Console.ReadLine());
            double totalSum = 0;
            for (int days = 1; days <= numberOfDays; days++)
            {
                double moneyPerEvenDay = 0;
                double moneyPerOddDay = 0;
                for (int hours = 1; hours <= numberOfHours; hours++)
                {
                    if (days % 2 == 0)
                    {
                        if (hours % 2 != 0)
                        {
                            moneyPerEvenDay += 2.5;
                        }
                        else
                        {
                            moneyPerEvenDay += 1;
                        }
                    }
                    else
                    {
                        if (hours % 2 == 0)
                        {
                            moneyPerOddDay += 1.25;
                        }
                        else
                        {
                            moneyPerOddDay += 1;
                        }
                    }
                }
                totalSum += moneyPerEvenDay + moneyPerOddDay;
                if (days % 2 == 0)
                {
                    Console.WriteLine($"Day: {days} - {moneyPerEvenDay:f2} leva");
                }
                else
                {
                    Console.WriteLine($"Day: {days} - {moneyPerOddDay:f2} leva");
                }
            }
            Console.WriteLine($"Total: {totalSum:f2} leva");
        }
    }
}
