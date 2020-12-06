using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double yard = double.Parse(Console.ReadLine());
            double money = yard * 7.61;
            double discount = money * 0.18;
            double finalMoney = money - discount;
            Console.WriteLine($"The final price is: {finalMoney} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
