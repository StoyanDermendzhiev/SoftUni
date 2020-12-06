using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupNumber = int.Parse(Console.ReadLine());
            var groupType = Console.ReadLine();
            var dayOfTheWeek = Console.ReadLine();
            var price = 0.0;

            if (groupType == "Students")
            {
                switch (dayOfTheWeek)
                {
                    case "Friday":
                        price = 8.45;
                        break;
                    case "Saturday":
                        price = 9.80;
                        break;
                    case "Sunday":
                        price = 10.46;
                        break;
                }
                if (groupNumber >= 30)
                {
                    price *= 0.85;
                }
            }
            else if (groupType == "Business")
            {
                switch (dayOfTheWeek)
                {
                    case "Friday":
                        price = 10.90;
                        break;
                    case "Saturday":
                        price = 15.60;
                        break;
                    case "Sunday":
                        price = 16;
                        break;
                }
                if (groupNumber >= 100)
                {
                    groupNumber -= 10;
                }
            }
            else if (groupType == "Regular")
            {
                switch (dayOfTheWeek)
                {
                    case "Friday":
                        price = 15;
                        break;
                    case "Saturday":
                        price = 20;
                        break;
                    case "Sunday":
                        price = 22.50;
                        break;
                }
                if (groupNumber >= 10 && groupNumber <= 20)
                {
                    price *= 0.95;
                }
            }
            var totalPrice = groupNumber * price;
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
