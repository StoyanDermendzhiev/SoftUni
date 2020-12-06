using System;

namespace _03.WorldSnookerChampionship
{
    class Program
    {
        static void Main(string[] args)
        {
            string stage = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int ticketNumber = int.Parse(Console.ReadLine());
            char photo = char.Parse(Console.ReadLine());
            double ticketPrice = 0;

            if (stage == "Quarter final")
            {
                switch (ticketType)
                {
                    case "Standard":
                        ticketPrice = 55.50;
                        break;
                    case "Premium":
                        ticketPrice = 105.20;
                        break;
                    case "VIP":
                        ticketPrice = 118.90;
                        break;
                }
            }
            else if (stage == "Semi final")
            {
                switch (ticketType)
                {
                    case "Standard":
                        ticketPrice = 75.88;
                        break;
                    case "Premium":
                        ticketPrice = 125.22;
                        break;
                    case "VIP":
                        ticketPrice = 300.40;
                        break;
                }
            }
            else if (stage == "Final")
            {
                switch (ticketType)
                {
                    case "Standard":
                        ticketPrice = 110.10;
                        break;
                    case "Premium":
                        ticketPrice = 160.66;
                        break;
                    case "VIP":
                        ticketPrice = 400;
                        break;
                }
            }
            double totalMoney = ticketNumber * ticketPrice;
            int photoPrice = 0;
            if (photo == 'Y' && totalMoney <= 4000)
            {
                photoPrice = 40;
            }
            if (totalMoney > 2500 && totalMoney <= 4000)
            {
                totalMoney *= 0.9;
            }
            else if (totalMoney > 4000)
            {
                totalMoney *= 0.75;
            }
            totalMoney += photoPrice * ticketNumber;

            Console.WriteLine($"{totalMoney:f2}");
        }
    }
}
