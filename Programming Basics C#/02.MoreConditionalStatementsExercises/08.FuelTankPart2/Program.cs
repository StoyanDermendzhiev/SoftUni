using System;

namespace _08.FuelTankPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Static data
            double gasolinePrice = 2.22;
            double dieselPrice = 2.33;
            double gasPrice = 0.93;
            //Input
            string fuelType = Console.ReadLine();
            double fuelQuantity = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();
            //Calculations
            if (clubCard == "Yes")
            {
                gasolinePrice -= 0.18;
                dieselPrice -= 0.12;
                gasPrice -= 0.08;
            }
            if (fuelQuantity >= 20 && fuelQuantity <= 25)
            {
                gasolinePrice *= 0.92;
                dieselPrice *= 0.92;
                gasPrice *= 0.92;
            }
            if (fuelQuantity > 25)
            {
                gasolinePrice *= 0.9;
                dieselPrice *= 0.9;
                gasPrice *= 0.9;
            }
            if (fuelType == "Gasoline")
            {
                double totalMoney = fuelQuantity * gasolinePrice;
                Console.WriteLine($"{totalMoney:f2} lv.");
            }
            else if (fuelType == "Diesel")
            {
                double totalMoney = fuelQuantity * dieselPrice;
                Console.WriteLine($"{totalMoney:f2} lv.");
            }
            else if (fuelType == "Gas")
            {
                double totalMoney = fuelQuantity * gasPrice;
                Console.WriteLine($"{totalMoney:f2} lv.");
            }
        }
    }
}
