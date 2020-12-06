using System;

namespace _02.TravelAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            int ticketNumber = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            int ticketPrice = int.Parse(Console.ReadLine());

            int totalMoney = ticketNumber * ticketPrice;
            if (totalMoney > budget)
            {
                Console.WriteLine($"The budget of {budget}$ is not enough. Your client can't buy {ticketNumber} tickets with this budget!");
            }
            else
            {
                Console.WriteLine($"You can sell your client {ticketNumber} tickets for the price of {totalMoney}$!");
                Console.WriteLine($"Your client should become a change of {budget-totalMoney}$!");
            }
        }
    }
}
