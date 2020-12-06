using System;

namespace _06.DailyWage
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberriesPrice = 3.50;
            double blueberriesPrice = 5.00;

            int rowsNumber = int.Parse(Console.ReadLine());
            int positionsNumber = int.Parse(Console.ReadLine());

            int strawberriesCount = 0;
            int blueberriesCount = 0;

            for (int row = 1; row <= rowsNumber; row++)
            {
                if (row % 2 != 0)
                {
                    for (int position = 1; position <= positionsNumber; position++)
                    {
                        strawberriesCount++;
                    }
                }
                else
                {
                    for (int position = 1; position <= positionsNumber; position++)
                    {
                        if (position % 3 != 0)
                        {
                            blueberriesCount++;
                        }
                    }
                }
            }
            double totalMoney = (strawberriesCount * strawberriesPrice + blueberriesPrice * blueberriesCount) * 0.80;
            Console.WriteLine($"Total: {totalMoney:f2} lv.");
        }
    }
}
