using System;

namespace _03.KartCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string tours = Console.ReadLine();
            string fanCard = Console.ReadLine();
            string kartType = Console.ReadLine();

            double price = 0;
            if (tours == "five")
            {
                switch (kartType)
                {
                    case "Child":
                        price = 7;
                        break;
                    case "Junior":
                        price = 9;
                        break;
                    case "Adult":
                        price = 12;
                        break;
                    case "Profi":
                        price = 18;
                        break;
                }
            }
            else if (tours == "ten")
            {
                switch (kartType)
                {
                    case "Child":
                        price = 11;
                        break;
                    case "Junior":
                        price = 16;
                        break;
                    case "Adult":
                        price = 21;
                        break;
                    case "Profi":
                        price = 32;
                        break;
                }
            }
            if (fanCard == "yes")
            {
                price -= price * 0.20;
            }
            if (money >= price)
            {
                Console.WriteLine($"You bought {kartType} ticket for {tours} laps. Your change is {money-price:f2}lv.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need {price-money:f2}lv more.");
            }
        }
    }
}
