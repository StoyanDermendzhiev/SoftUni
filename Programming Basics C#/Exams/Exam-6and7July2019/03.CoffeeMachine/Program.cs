using System;

namespace _03.CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int drinksNumber = int.Parse(Console.ReadLine());
            double drinkPrice = 0;

            if (drink == "Espresso")
            {
                switch (sugar)
                {
                    case "Without":
                        drinkPrice = 0.90;
                        break;
                    case "Normal":
                        drinkPrice = 1;
                        break;
                    case "Extra":
                        drinkPrice = 1.20;
                        break;
                }
            }
            else if (drink == "Cappuccino")
            {
                switch (sugar)
                {
                    case "Without":
                        drinkPrice = 1;
                        break;
                    case "Normal":
                        drinkPrice = 1.20;
                        break;
                    case "Extra":
                        drinkPrice = 1.60;
                        break;
                }
            }
            else if (drink == "Tea")
            {
                switch (sugar)
                {
                    case "Without":
                        drinkPrice = 0.50;
                        break;
                    case "Normal":
                        drinkPrice = 0.60;
                        break;
                    case "Extra":
                        drinkPrice = 0.70;
                        break;
                }
            }
            if (sugar == "Without")
            {
                drinkPrice -= drinkPrice * 0.35;
            }
            if (drink == "Espresso" && drinksNumber >= 5)
            {
                drinkPrice -= drinkPrice * 0.25;
            }
            double totalMoney = drinksNumber * drinkPrice;
            if (totalMoney > 15)
            {
                totalMoney -= totalMoney * 0.20;
            }
            Console.WriteLine($"You bought {drinksNumber} cups of {drink} for {totalMoney:f2} lv.");
        }
    }
}
