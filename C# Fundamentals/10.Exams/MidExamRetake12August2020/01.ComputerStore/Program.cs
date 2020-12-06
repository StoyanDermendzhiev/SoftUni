using System;

namespace _01.ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double totalPriceWithoutTaxes = 0;

            while (command != "special" && command != "regular")
            {
                double price = double.Parse(command);

                if (price <= 0)
                {
                    Console.WriteLine("Invalid price!");
                    price = 0;
                }

                totalPriceWithoutTaxes += price;

                command = Console.ReadLine();
            }

            if (totalPriceWithoutTaxes == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            double totalPrice = totalPriceWithoutTaxes * 1.2;
            double taxes = totalPriceWithoutTaxes * 0.2;

            if (command == "special")
            {
                totalPrice *= 0.9;
            }

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {totalPriceWithoutTaxes:f2}$");
            Console.WriteLine($"Taxes: {taxes:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {totalPrice:f2}$");
        }
    }
}
