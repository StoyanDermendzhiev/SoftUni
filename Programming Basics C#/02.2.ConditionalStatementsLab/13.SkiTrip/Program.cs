using System;

namespace _13.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string opinion = Console.ReadLine();
            //Calculations
            int nights = days - 1;
            double price = 0;
            double discount = 1;
            double opinionPrice = 0;
            if (opinion == "positive")
            {
                opinionPrice = 1.25;
            }
            else if (opinion == "negative")
            {
                opinionPrice = 0.9;
            }
            if (days < 10)
            {
                switch (roomType)
                {
                    case "room for one person":
                        price = 18.00;
                        break;
                    case "apartment":
                        discount = 0.70;
                        price = 25.00;
                        break;
                    case "president apartment":
                        discount = 0.90;
                        price = 35.00;
                        break;
                }
            }
            else if (days >= 10 && days <= 15)
            {
                switch (roomType)
                {
                    case "room for one person":
                        price = 18.00;
                        break;
                    case "apartment":
                        discount = 0.65;
                        price = 25.00;
                        break;
                    case "president apartment":
                        discount = 0.85;
                        price = 35.00;
                        break;
                }
            }
            else if (days > 15)
            {
                switch (roomType)
                {
                    case "room for one person":
                        price = 18.00;
                        break;
                    case "apartment":
                        discount = 0.50;
                        price = 25.00;
                        break;
                    case "president apartment":
                        discount = 0.80;
                        price = 35.00;
                        break;
                }
            }
            Console.WriteLine($"{nights * price * discount * opinionPrice:f2}");
        }
    }
}

