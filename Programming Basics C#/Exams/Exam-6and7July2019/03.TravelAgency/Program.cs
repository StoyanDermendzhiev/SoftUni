using System;

namespace _03.TravelAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            string package = Console.ReadLine();
            string vipDiscount = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double price = 0;

            if ((city == "Bansko" || city == "Borovets") && vipDiscount == "no")
            {
                if (package == "noEquipment")
                {
                    price = 80;
                }
                else if (package == "withEquipment")
                {
                    price = 100;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    return;
                }
            }
            else if ((city == "Bansko" || city == "Borovets") && vipDiscount == "yes")
            {
                if (package == "noEquipment")
                {
                    price = 80 - 80 * 0.05;
                }
                else if (package == "withEquipment")
                {
                    price = 100 - 100 * 0.1;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    return;
                }
            }
            else if ((city == "Varna" || city == "Burgas") && vipDiscount == "no")
            {
                if (package == "noBreakfast")
                {
                    price = 100;
                }
                else if (package == "withBreakfast")
                {
                    price = 130;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    return;
                }
            }
            else if ((city == "Varna" || city == "Burgas") && vipDiscount == "yes")
            {
                if (package == "noBreakfast")
                {
                    price = 100 - 100 * 0.07;
                }
                else if (package == "withBreakfast")
                {
                    price = 130 - 130 * 0.12;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            if (days > 7)
            {
                days -= 1;
            }
            double totalMoney = days * price;
            if (days <= 0)
            {
                Console.WriteLine("Days must be positive number!");
            }
            else
            {
                Console.WriteLine($"The price is {totalMoney:f2}lv! Have a nice time!");
            }
        }
    }
}
