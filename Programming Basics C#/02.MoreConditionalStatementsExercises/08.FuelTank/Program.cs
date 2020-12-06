using System;

namespace _08.FuelTank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string fuel = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            //Calculations
            if ((fuel == "Diesel" || fuel == "Gasoline" || fuel == "Gas") && quantity >= 25)
            {
                Console.WriteLine($"You have enough {fuel.ToLower()}.");
            }
            else if ((fuel == "Diesel" || fuel == "Gasoline" || fuel == "Gas") && quantity < 25)
            {
                Console.WriteLine($"Fill your tank with {fuel.ToLower()}!");
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
