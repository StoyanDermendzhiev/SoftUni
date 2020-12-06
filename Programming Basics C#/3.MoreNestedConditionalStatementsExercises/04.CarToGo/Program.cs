using System;

namespace _04.CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            //Calculations
            string carType = "type";
            string carClass = "class";
            if (season == "Summer")
            {
                carType = "Cabrio";
            }
            else if (season == "Winter")
            {
                carType = "Jeep";
            }
            if (budget <= 100)
            {
                carClass = "Economy class";
                switch (season)
                {
                    case "Summer":
                        budget *= 0.35;
                        break;
                    case "Winter":
                        budget *= 0.65;
                        break;
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                carClass = "Compact class";
                switch (season)
                {
                    case "Summer":
                        budget *= 0.45;
                        break;
                    case "Winter":
                        budget *= 0.80;
                        break;
                }
            }
            else if (budget > 500)
            {
                carClass = "Luxury class";
                carType = "Jeep";
                budget *= 0.90;
            }
            Console.WriteLine(carClass);
            Console.WriteLine($"{carType} - {budget:f2}");
        }
    }
}
