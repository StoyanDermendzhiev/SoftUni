using System;
using System.Xml.Schema;

namespace _07.FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Static data
            double magnolias = 3.25;
            double hyacinths = 4.00;
            double roses = 3.50;
            double cactuses = 8.00;
            //Input
            int magnoliasNumber = int.Parse(Console.ReadLine());
            int hyacinthsNumber = int.Parse(Console.ReadLine());
            int rosesNumber = int.Parse(Console.ReadLine());
            int cactusesNumber = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());
            //Calculations
            double totalMoney = magnolias * magnoliasNumber + hyacinths * hyacinthsNumber + roses * rosesNumber + cactuses * cactusesNumber;
            totalMoney *= 0.95;
            if (totalMoney>=giftPrice)
            {
                double moneyLeft = Math.Floor(totalMoney - giftPrice);
                Console.WriteLine($"She is left with {moneyLeft} leva.");
            }
            else
            {
                double moneyNeeded = Math.Ceiling(giftPrice - totalMoney);
                Console.WriteLine($"She will have to borrow {moneyNeeded} leva.");
            }
        }
    }
}
