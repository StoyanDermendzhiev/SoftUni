using System;

namespace _01.EasterLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfEasterBreads = int.Parse(Console.ReadLine());
            int numberOfEggsPacks = int.Parse(Console.ReadLine());
            int cookiesKilos = int.Parse(Console.ReadLine());
            double totalMoney = numberOfEasterBreads * 3.2 + cookiesKilos * 5.4 + numberOfEggsPacks * 4.35 + numberOfEggsPacks * 12 * 0.15;
            Console.WriteLine($"{totalMoney:f2}");
        }
    }
}
