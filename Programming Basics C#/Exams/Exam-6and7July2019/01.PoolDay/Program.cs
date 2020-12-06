using System;

namespace _01.PoolDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            double entrancePrice = double.Parse(Console.ReadLine());
            double sunbedPrice = double.Parse(Console.ReadLine());
            double umbrellaPrice = double.Parse(Console.ReadLine());

            double umbrelaNumber = Math.Ceiling(1.0 * people / 2);
            double sunbedNumber = Math.Ceiling(people * 0.75);

            double totalMoney = people * entrancePrice + sunbedNumber * sunbedPrice + umbrelaNumber * umbrellaPrice;

            Console.WriteLine($"{totalMoney:f2} lv.");
        }
    }
}
