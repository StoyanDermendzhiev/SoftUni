using System;

namespace _01.BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double inheritance = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int yearsOld = 18;
            double spentMoney = 0;
            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                {
                    spentMoney += 12000;
                }
                else
                {
                    spentMoney += 12000 + 50 * yearsOld;
                }
                yearsOld += 1;
            }
            if (inheritance >= spentMoney)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {inheritance - spentMoney:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {spentMoney - inheritance:f2} dollars to survive.");
            }
        }
    }
}
