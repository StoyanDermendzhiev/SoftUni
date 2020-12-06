using System;

namespace _04.Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double incomeWanted = double.Parse(Console.ReadLine());
            string cocktailName = Console.ReadLine();

            double totalIncome = 0;

            while (cocktailName != "Party!")
            {
                int cocktailNumberPerOrder = int.Parse(Console.ReadLine());
                double moneyPerOrder = 0;
                moneyPerOrder += cocktailName.Length * cocktailNumberPerOrder;
                if (moneyPerOrder % 2 != 0)
                {
                    moneyPerOrder -= moneyPerOrder * 0.25;
                }
                totalIncome += moneyPerOrder;
                if (totalIncome >= incomeWanted)
                {
                    Console.WriteLine("Target acquired.");
                    break;
                }

                cocktailName = Console.ReadLine();
            }
            if (totalIncome < incomeWanted)
            {
                Console.WriteLine($"We need {incomeWanted-totalIncome:f2} leva more.");
            }
            Console.WriteLine($"Club income - {totalIncome:f2} leva.");
        }
    }
}
