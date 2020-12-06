using System;

namespace _03.FilmPremiere
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            string moviePackage = Console.ReadLine();
            int ticketNumber = int.Parse(Console.ReadLine());
            double packagePrice = 0;

            if (movieName == "John Wick")
            {
                switch (moviePackage)
                {
                    case "Drink":
                        packagePrice = 12;
                        break;
                    case "Popcorn":
                        packagePrice = 15;
                        break;
                    case "Menu":
                        packagePrice = 19;
                        break;
                }
            }
            else if (movieName == "Star Wars")
            {
                switch (moviePackage)
                {
                    case "Drink":
                        packagePrice = 18;
                        break;
                    case "Popcorn":
                        packagePrice = 25;
                        break;
                    case "Menu":
                        packagePrice = 30;
                        break;
                }
            }
            else if (movieName == "Jumanji")
            {
                switch (moviePackage)
                {
                    case "Drink":
                        packagePrice = 9;
                        break;
                    case "Popcorn":
                        packagePrice = 11;
                        break;
                    case "Menu":
                        packagePrice = 14;
                        break;
                }
            }
            if (movieName == "Star Wars" && ticketNumber >= 4)
            {
                packagePrice *= 0.70;
            }
            if (movieName == "Jumanji" && ticketNumber == 2)
            {
                packagePrice *= 0.85;
            }
            double totalMoney = packagePrice * ticketNumber;
            Console.WriteLine($"Your bill is {totalMoney:f2} leva.");
        }
    }
}
