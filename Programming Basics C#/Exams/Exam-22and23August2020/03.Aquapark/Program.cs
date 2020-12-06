using System;

namespace _03.Aquapark
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int hours = int.Parse(Console.ReadLine());
            int peopleInGroup = int.Parse(Console.ReadLine());
            string timeOfTheDay = Console.ReadLine();
            
            double pricePerHour = 0;

            if (timeOfTheDay == "day")
            {
                switch (month)
                {
                    case "march":
                    case "april":
                    case "may":
                        pricePerHour = 10.50;
                        break;
                    case "june":
                    case "july":
                    case "august":
                        pricePerHour = 12.60;
                        break;
                }
            }
            else if (timeOfTheDay == "night")
            {
                switch (month)
                {
                    case "march":
                    case "april":
                    case "may":
                        pricePerHour = 8.4;
                        break;
                    case "june":
                    case "july":
                    case "august":
                        pricePerHour = 10.20;
                        break;
                }
            }
            if (peopleInGroup >= 4)
            {
                pricePerHour *= 0.9;
            }
            if (hours >= 5)
            {
                pricePerHour *= 0.5;
            }
            double totalMoney = pricePerHour * hours * peopleInGroup;

            Console.WriteLine($"Price per person for one hour: {pricePerHour:f2}");
            Console.WriteLine($"Total cost of the visit: {totalMoney:f2}");
        }
    }
}
