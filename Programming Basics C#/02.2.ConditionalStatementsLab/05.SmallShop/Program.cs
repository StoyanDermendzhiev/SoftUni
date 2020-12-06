using System;

namespace _05.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            //Calculations
            double price = 0;
            if (city == "Sofia")
            {
                switch (product)
                {
                    case "coffee":
                        price = quantity*0.50;
                        Console.WriteLine(price);
                        break;
                    case "water":
                        price = quantity * 0.80;
                        Console.WriteLine(price);
                        break;
                    case "beer":
                        price = quantity * 1.20;
                        Console.WriteLine(price);
                        break;
                    case "sweets":
                        price = quantity * 1.45;
                        Console.WriteLine(price);
                        break;
                    case "peanuts":
                        price = quantity * 1.60;
                        Console.WriteLine(price);
                        break;
                }
            }
            else if (city == "Plovdiv")
            {
                switch (product)
                {
                    case "coffee":
                        price = quantity * 0.40;
                        Console.WriteLine(price);
                        break;
                    case "water":
                        price = quantity * 0.70;
                        Console.WriteLine(price);
                        break;
                    case "beer":
                        price = quantity * 1.15;
                        Console.WriteLine(price);
                        break;
                    case "sweets":
                        price = quantity * 1.30;
                        Console.WriteLine(price);
                        break;
                    case "peanuts":
                        price = quantity * 1.50;
                        Console.WriteLine(price);
                        break;
                }
            }
            else if (city == "Varna")
            {
                switch (product)
                {
                    case "coffee":
                        price = quantity * 0.45;
                        Console.WriteLine(price);
                        break;
                    case "water":
                        price = quantity * 0.70;
                        Console.WriteLine(price);
                        break;
                    case "beer":
                        price = quantity * 1.10;
                        Console.WriteLine(price);
                        break;
                    case "sweets":
                        price = quantity * 1.35;
                        Console.WriteLine(price);
                        break;
                    case "peanuts":
                        price = quantity * 1.55;
                        Console.WriteLine(price);
                        break;
                }
            }
        }
    }
}
