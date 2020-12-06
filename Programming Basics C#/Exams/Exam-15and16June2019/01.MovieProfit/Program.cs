using System;

namespace _01.MovieProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int daysNumber = int.Parse(Console.ReadLine());
            int ticketNumber = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            int percentForCinema = int.Parse(Console.ReadLine());

            double totalMoney = daysNumber * ticketNumber * ticketPrice;
            totalMoney -= totalMoney * percentForCinema / 100;

            Console.WriteLine($"The profit from the movie {movieName} is {totalMoney:f2} lv.");
        }
    }
}
