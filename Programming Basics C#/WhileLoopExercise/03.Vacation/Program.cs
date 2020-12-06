using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            int dayCount = 0;
            int spendCount = 0;
            while (availableMoney < moneyNeeded)
            {
                
                string spendOrSave = Console.ReadLine();
                double moneySpendOrSave = double.Parse(Console.ReadLine());
                dayCount++;
                if (spendOrSave == "spend")
                {
                    spendCount++;
                    if (spendCount == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{dayCount}");
                        Environment.Exit(0);
                    }
                    if (availableMoney < moneySpendOrSave)
                    {
                        availableMoney = 0;
                    }
                    else
                    {
                        availableMoney -= moneySpendOrSave;
                    }
                }
                else
                {
                    spendCount = 0;
                    availableMoney += moneySpendOrSave;
                }
            }
            Console.WriteLine($"You saved the money for {dayCount} days.");
        }
    }
}
