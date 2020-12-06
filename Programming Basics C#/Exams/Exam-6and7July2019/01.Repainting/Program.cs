using System;

namespace _01.Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylonArea = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double money = (nylonArea + 2) * 1.5 + (paint + paint * 0.1) * 14.50 + thinner * 5 + 0.4;
            double totalMoney = money + money * 0.3 * hours;

            Console.WriteLine($"Total expenses: {totalMoney:f2} lv.");
        }
    }
}
