using System;

namespace _01.PCStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double usdToBgnConvert = 1.57;
            
            double cpuPriceInDollars = double.Parse(Console.ReadLine());
            double videocardPriceInDollars = double.Parse(Console.ReadLine());
            double ramPriceInDollars = double.Parse(Console.ReadLine());
            int ramNumber = int.Parse(Console.ReadLine());
            double percentDiscount = double.Parse(Console.ReadLine());

            double totalMoneyInDollars = (cpuPriceInDollars + videocardPriceInDollars) - (cpuPriceInDollars + videocardPriceInDollars) * percentDiscount + ramPriceInDollars * ramNumber;
            double totalMoneyInBgn = totalMoneyInDollars * usdToBgnConvert;

            Console.WriteLine($"Money needed - {totalMoneyInBgn:f2} leva.");
        }
    }
}
