using System;

namespace _01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string projectionType = Console.ReadLine();
            int rowNumber = int.Parse(Console.ReadLine());
            int columnNumber = int.Parse(Console.ReadLine());
            //Calculations
            double ticketPrice = 0;
            switch (projectionType)
            {
                case "Premiere":
                    ticketPrice = 12.00;
                    break;
                case "Normal":
                    ticketPrice = 7.50;
                    break;
                case "Discount":
                    ticketPrice = 5.00;
                    break;
            }
            double totalMoney = rowNumber * columnNumber * ticketPrice;
            Console.WriteLine($"{totalMoney:f2}");
        }
    }
}
