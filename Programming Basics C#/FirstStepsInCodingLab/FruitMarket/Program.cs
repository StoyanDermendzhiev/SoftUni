using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double berryPrice = double.Parse(Console.ReadLine());
            double banana = double.Parse(Console.ReadLine());
            double orange = double.Parse(Console.ReadLine());
            double raspberry = double.Parse(Console.ReadLine());
            double berry = double.Parse(Console.ReadLine());
            //Calculations
            double raspberryPrice = berryPrice * 0.5;
            double orangePrice = raspberryPrice * 0.6;
            double bananaPrice = raspberryPrice * 0.2;
            double money = berry * berryPrice + raspberry * raspberryPrice + orange * orangePrice + banana * bananaPrice;
            //Output
            Console.WriteLine($"{money:F2}");
        }
    }
}
