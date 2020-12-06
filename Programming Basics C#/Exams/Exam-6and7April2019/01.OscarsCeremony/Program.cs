using System;

namespace _01.OscarsCeremony
{
    class Program
    {
        static void Main(string[] args)
        {
            int hallRent = int.Parse(Console.ReadLine());

            double statuettePrice = hallRent - hallRent * 0.3;
            double cateringPrice = statuettePrice - statuettePrice * 0.15;
            double soundSystemPrice = cateringPrice / 2;

            double totalMoney = hallRent + statuettePrice + cateringPrice + soundSystemPrice;

            Console.WriteLine($"{totalMoney:f2}");
        }
    }
}
