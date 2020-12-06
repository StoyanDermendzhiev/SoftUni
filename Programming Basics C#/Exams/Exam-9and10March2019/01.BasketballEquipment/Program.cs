using System;

namespace _01.BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearTax = int.Parse(Console.ReadLine());

            double sneakersPrice = yearTax - yearTax * 0.4;
            double basketballKit = sneakersPrice - sneakersPrice * 0.2;
            double ballPrice = basketballKit / 4;
            double basketballAccessories = ballPrice / 5;

            double totalMoney = yearTax + sneakersPrice + basketballKit + ballPrice + basketballAccessories;

            Console.WriteLine($"{totalMoney:f2}");
        }
    }
}
