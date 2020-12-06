using System;

namespace _01.MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Static data
            double vipTicketPrice = 499.99;
            double normalTicketPrice = 249.99;
            //Input
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int numberOfFans = int.Parse(Console.ReadLine());
            //Calculations
            double moneyLeft = 0;
            double moneyNeeded = 0;
            if (numberOfFans>=1 && numberOfFans<=4)
            {
                switch (category)
                {
                    case "VIP":
                        budget *= 0.25;
                        if (budget>=numberOfFans*vipTicketPrice)
                        {
                            moneyLeft = budget - numberOfFans * vipTicketPrice;
                            Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                        }
                        else
                        {
                            moneyNeeded = numberOfFans * vipTicketPrice - budget;
                            Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
                        }
                        break;
                    case "Normal":
                        budget *= 0.25;
                        if (budget >= numberOfFans * normalTicketPrice)
                        {
                            moneyLeft = budget - numberOfFans * normalTicketPrice;
                            Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                        }
                        else
                        {
                            moneyNeeded = numberOfFans * normalTicketPrice - budget;
                            Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
                        }
                        break;
                }
            }
            else if (numberOfFans >= 5 && numberOfFans <= 9)
            {
                switch (category)
                {
                    case "VIP":
                        budget *= 0.40;
                        if (budget >= numberOfFans * vipTicketPrice)
                        {
                            moneyLeft = budget - numberOfFans * vipTicketPrice;
                            Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                        }
                        else
                        {
                            moneyNeeded = numberOfFans * vipTicketPrice - budget;
                            Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
                        }
                        break;
                    case "Normal":
                        budget *= 0.40;
                        if (budget >= numberOfFans * normalTicketPrice)
                        {
                            moneyLeft = budget - numberOfFans * normalTicketPrice;
                            Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                        }
                        else
                        {
                            moneyNeeded = numberOfFans * normalTicketPrice - budget;
                            Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
                        }
                        break;
                }
            }
            else if (numberOfFans >= 10 && numberOfFans <= 24)
            {
                switch (category)
                {
                    case "VIP":
                        budget *= 0.50;
                        if (budget >= numberOfFans * vipTicketPrice)
                        {
                            moneyLeft = budget - numberOfFans * vipTicketPrice;
                            Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                        }
                        else
                        {
                            moneyNeeded = numberOfFans * vipTicketPrice - budget;
                            Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
                        }
                        break;
                    case "Normal":
                        budget *= 0.50;
                        if (budget >= numberOfFans * normalTicketPrice)
                        {
                            moneyLeft = budget - numberOfFans * normalTicketPrice;
                            Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                        }
                        else
                        {
                            moneyNeeded = numberOfFans * normalTicketPrice - budget;
                            Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
                        }
                        break;
                }
            }
            else if (numberOfFans >= 25 && numberOfFans <= 49)
            {
                switch (category)
                {
                    case "VIP":
                        budget *= 0.60;
                        if (budget >= numberOfFans * vipTicketPrice)
                        {
                            moneyLeft = budget - numberOfFans * vipTicketPrice;
                            Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                        }
                        else
                        {
                            moneyNeeded = numberOfFans * vipTicketPrice - budget;
                            Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
                        }
                        break;
                    case "Normal":
                        budget *= 0.60;
                        if (budget >= numberOfFans * normalTicketPrice)
                        {
                            moneyLeft = budget - numberOfFans * normalTicketPrice;
                            Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                        }
                        else
                        {
                            moneyNeeded = numberOfFans * normalTicketPrice - budget;
                            Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
                        }
                        break;
                }
            }
            else if (numberOfFans >= 50)
            {
                switch (category)
                {
                    case "VIP":
                        budget *= 0.75;
                        if (budget >= numberOfFans * vipTicketPrice)
                        {
                            moneyLeft = budget - numberOfFans * vipTicketPrice;
                            Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                        }
                        else
                        {
                            moneyNeeded = numberOfFans * vipTicketPrice - budget;
                            Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
                        }
                        break;
                    case "Normal":
                        budget *= 0.75;
                        if (budget >= numberOfFans * normalTicketPrice)
                        {
                            moneyLeft = budget - numberOfFans * normalTicketPrice;
                            Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
                        }
                        else
                        {
                            moneyNeeded = numberOfFans * normalTicketPrice - budget;
                            Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
                        }
                        break;
                }
            }
        }
    }
}
