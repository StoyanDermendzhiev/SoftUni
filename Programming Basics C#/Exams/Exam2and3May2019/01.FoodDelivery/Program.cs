using System;

namespace _01.FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            double chickenMenuNumber = int.Parse(Console.ReadLine());
            double fishMenuNumber = int.Parse(Console.ReadLine());
            double veganMenuNumber = int.Parse(Console.ReadLine());

            double totalMoney = chickenMenuNumber * 10.35 + fishMenuNumber * 12.40 + veganMenuNumber * 8.15;
            double totalMoneyWithDesert = totalMoney + totalMoney * 0.2;
            double totalMoneyWithDelivery = totalMoneyWithDesert + 2.5;

            Console.WriteLine($"Total: {totalMoneyWithDelivery:f2}");
        }
    }
}
