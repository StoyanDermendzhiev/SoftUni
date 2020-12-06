using System;

namespace _05.Series
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int seriesNumber = int.Parse(Console.ReadLine());

            for (int serries = 1; serries <= seriesNumber; serries++)
            {
                string serriesName = Console.ReadLine();
                double serriesPrice = double.Parse(Console.ReadLine());

                switch (serriesName)
                {
                    case "Thrones":
                        serriesPrice *= 0.5;
                        break;
                    case "Lucifer":
                        serriesPrice *= 0.6;
                        break;
                    case "Protector":
                        serriesPrice *= 0.7;
                        break;
                    case "TotalDrama":
                        serriesPrice *= 0.8;
                        break;
                    case "Area":
                        serriesPrice *= 0.9;
                        break;
                }
                budget -= serriesPrice;
            }
            if (budget < 0)
            {
                Console.WriteLine($"You need {Math.Abs(budget):f2} lv. more to buy the series!");
            }
            else
            {
                Console.WriteLine($"You bought all the series and left with {budget:f2} lv.");
            }
        }
    }
}
