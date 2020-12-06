using System;

namespace _07.SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            //Calculations
            double nightPrice = 0;
            string sport = "0";
            double totalPrice = 0;
            switch (groupType)
            {
                case "boys":
                    switch (season)
                    {
                        case "Winter":
                            nightPrice = 9.60;
                            sport = "Judo";
                            break;
                        case "Spring":
                            nightPrice = 7.20;
                            sport = "Tennis";
                            break;
                        case "Summer":
                            nightPrice = 15;
                            sport = "Football";
                            break;
                    }
                    break;
                case "girls":
                    switch (season)
                    {
                        case "Winter":
                            nightPrice = 9.60;
                            sport = "Gymnastics";
                            break;
                        case "Spring":
                            nightPrice = 7.20;
                            sport = "Athletics";
                            break;
                        case "Summer":
                            nightPrice = 15;
                            sport = "Volleyball";
                            break;
                    }
                    break;
                case "mixed":
                    switch (season)
                    {
                        case "Winter":
                            nightPrice = 10;
                            sport = "Ski";
                            break;
                        case "Spring":
                            nightPrice = 9.50;
                            sport = "Cycling";
                            break;
                        case "Summer":
                            nightPrice = 20;
                            sport = "Swimming";
                            break;
                    }
                    break;
            }
            if (students >= 50)
            {
                totalPrice = students * nightPrice * nights * 0.50;
            }
            else if (students >= 20 && students < 50)
            {
                totalPrice = students * nightPrice * nights - students * nightPrice * nights * 0.15;
            }
            else if ( students >= 10 && students < 20)
            {
                totalPrice = students * nightPrice * nights - students * nightPrice * nights * 0.05;
            }
            else
            {
                totalPrice = students * nightPrice * nights;
            }
            Console.WriteLine($"{sport} {totalPrice:f2} lv.");
        }
    }
}
