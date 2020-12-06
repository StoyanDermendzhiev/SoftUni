using System;

namespace _05.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            //Calculations
            string accommodationType = "0";
            string location = "0";
            double accommodationPrice = 0;
            if (budget <= 1000)
            {
                accommodationType = "Camp";
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        accommodationPrice = budget * 0.65;
                        break;
                    case "Winter":
                        location = "Morocco";
                        accommodationPrice = budget * 0.45;
                        break;
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                accommodationType = "Hut";
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        accommodationPrice = budget * 0.80;
                        break;
                    case "Winter":
                        location = "Morocco";
                        accommodationPrice = budget * 0.60;
                        break;
                }
            }
            else if (budget > 3000)
            {
                accommodationType = "Hotel";
                accommodationPrice = budget * 0.90;
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        break;
                    case "Winter":
                        location = "Morocco";
                        break;
                }
            }
            Console.WriteLine($"{location} - {accommodationType} - {accommodationPrice:f2}");
        }
    }
}
