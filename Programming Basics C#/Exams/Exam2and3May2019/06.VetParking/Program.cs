using System;

namespace _06.VetParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysNumber = int.Parse(Console.ReadLine());
            int hoursNumber = int.Parse(Console.ReadLine());
            int dayCount = 0;
            double totalMoney = 0;

            for (int day = 1; day <= daysNumber; day++)
            {
                double totalDayMoney = 0;
                dayCount++;
                for (int hour = 1; hour <= hoursNumber; hour++)
                {
                    double price = 1.0;
                    if (day % 2 == 0 && hour % 2 != 0)
                    {
                        price = 2.50;
                    }
                    else if (day % 2 != 0 && hour % 2 == 0)
                    {
                        price = 1.25;
                    }
                    totalDayMoney += price;
                }
                Console.WriteLine($"Day: {dayCount} - {totalDayMoney:f2} leva");
                totalMoney += totalDayMoney;
            }
            Console.WriteLine($"Total: {totalMoney:f2} leva");
        }
    }
}
