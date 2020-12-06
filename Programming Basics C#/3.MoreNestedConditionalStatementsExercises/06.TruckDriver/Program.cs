using System;

namespace _06.TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            //                                Пролет / Есен       Лято            Зима
            //км на месец <= 5000             0.75 лв./ км    0.90 лв./ км    1.05 лв./ км
            //5000 < км на месец <= 10000     0.95 лв./ км    1.10 лв./ км     1.25 лв./ км
            //10000 < км на месец <= 20000        1.45 лв./ км – за който и да е сезон

            //Input
            string season = Console.ReadLine();
            double monthlyDistance = double.Parse(Console.ReadLine());
            //Calculations
            double price = 0;
            if (monthlyDistance <= 5000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        price = 0.75;
                        break;
                    case "Summer":
                        price = 0.90;
                        break;
                    case "Winter":
                        price = 1.05;
                        break;
                }
            }
            else if (monthlyDistance > 5000 && monthlyDistance <= 10000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        price = 0.95;
                        break;
                    case "Summer":
                        price = 1.10;
                        break;
                    case "Winter":
                        price = 1.25;
                        break;
                }
            }
            else if (monthlyDistance > 10000 && monthlyDistance <= 20000)
            {
                price = 1.45;
            }
            double wage = monthlyDistance * 4 * price;
            wage = wage - wage * 0.1;
            Console.WriteLine($"{wage:f2}");
        }
    }
}
