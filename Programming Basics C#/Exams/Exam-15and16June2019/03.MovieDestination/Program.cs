using System;

namespace _03.MovieDestination
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double dayPrice = 0;

            if (season == "Winter")
            {
                switch (destination)
                {
                    case "Dubai":
                        dayPrice = 45000;
                        break;
                    case "Sofia":
                        dayPrice = 17000;
                        break;
                    case "London":
                        dayPrice = 24000;
                        break;
                }
            }
            else if (season == "Summer")
            {
                switch (destination)
                {
                    case "Dubai":
                        dayPrice = 40000;
                        break;
                    case "Sofia":
                        dayPrice = 12500;
                        break;
                    case "London":
                        dayPrice = 20250;
                        break;
                }
            }
            double totalMoney = days * dayPrice;
            if (destination == "Dubai")
            {
                totalMoney -= totalMoney * 0.3;
            }
            if (destination == "Sofia")
            {
                totalMoney += totalMoney * 0.25;
            }
            if (budget >= totalMoney)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {budget-totalMoney:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {totalMoney-budget:f2} leva more!");
            }
        }
    }
}
