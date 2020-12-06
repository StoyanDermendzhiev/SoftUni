using System;

namespace _04.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Static data
            double taxiStartingTax = 0.70;
            double taxiDayTax = 0.79;
            double taxiNightTax = 0.90;
            double busTax = 0.09;
            double trainTax = 0.06;
            //Input
            int km = int.Parse(Console.ReadLine());
            string dayAndNight = Console.ReadLine();
            //Calculations
            double totalMoney = 0.0;
            if (km < 20 && dayAndNight == "day")
            {
                totalMoney = km * taxiDayTax + taxiStartingTax;
                Console.WriteLine($"{totalMoney:f2}");
            }
            else if (km < 20 && dayAndNight == "night")
            {
                totalMoney = km * taxiNightTax + taxiStartingTax;
                Console.WriteLine($"{totalMoney:f2}");
            }
            else if (km >= 20 && km < 100)
            {
                totalMoney = km * busTax;
                Console.WriteLine($"{totalMoney:f2}");
            }
            else if (km >= 100)
            {
                totalMoney = km * trainTax;
                Console.WriteLine($"{totalMoney:f2}");
            }

        }
    }
}
