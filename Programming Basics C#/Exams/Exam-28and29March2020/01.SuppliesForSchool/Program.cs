using System;

namespace _01.SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            double pensPrice = 5.80;
            double markersPrice = 7.20;
            double cleanerPrice = 1.20;
            //Input
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            double cleaner = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());
            //Calculations
            double money = pens * pensPrice + markers * markersPrice + cleaner * cleanerPrice;
            double finalMoney = money - ((money * discount) / 100);
            //Output
            Console.WriteLine($"{finalMoney:F3}");
        }
    }
}
