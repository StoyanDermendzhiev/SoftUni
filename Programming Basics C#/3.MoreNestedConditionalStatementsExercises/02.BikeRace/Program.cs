using System;

namespace _02.BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int juniorCyclists = int.Parse(Console.ReadLine());
            int seniorCyclists = int.Parse(Console.ReadLine());
            string track = Console.ReadLine();
            //Calculations
            double donateMoney = 0;
            switch (track)
            {
                case "trail":
                    donateMoney = (juniorCyclists * 5.50 + seniorCyclists * 7) * 0.95;
                    Console.WriteLine($"{donateMoney:f2}");
                    break;
                case "cross-country":
                    if ((juniorCyclists+seniorCyclists)>=50)
                    {
                        donateMoney = (juniorCyclists * 8 * 0.75 + seniorCyclists * 9.50 * 0.75) * 0.95;
                        Console.WriteLine($"{donateMoney:f2}");
                    }
                    else
                    {
                        donateMoney = (juniorCyclists * 8 + seniorCyclists * 9.50) * 0.95;
                        Console.WriteLine($"{donateMoney:f2}");
                    }
                    break;
                case "downhill":
                    donateMoney = (juniorCyclists * 12.25 + seniorCyclists * 13.75) * 0.95;
                    Console.WriteLine($"{donateMoney:f2}");
                    break;
                case "road":
                    donateMoney = (juniorCyclists * 20 + seniorCyclists * 21.50) * 0.95;
                    Console.WriteLine($"{donateMoney:f2}");
                    break;
            }
        }
    }
}
