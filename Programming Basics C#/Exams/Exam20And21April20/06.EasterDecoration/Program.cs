using System;

namespace _06.EasterDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int clientNumber = int.Parse(Console.ReadLine());
            double decorationPrice = 0;
            int totalCount = 0;
            double totalMoney = 0;
            for (int client = 1; client <= clientNumber; client++)
            {
                string decorationType = Console.ReadLine();
                double totalMoneyPerClient = 0;
                int totalCountPerClient = 0;
                while (decorationType != "Finish")
                {
                    int decorationCountPerClient = 0;
                    switch (decorationType)
                    {
                        case "basket":
                            decorationCountPerClient++;
                            decorationPrice = 1.50;
                            break;
                        case "wreath":
                            decorationCountPerClient++;
                            decorationPrice = 3.80;
                            break;
                        case "chocolate bunny":
                            decorationCountPerClient++;
                            decorationPrice = 7;
                            break;
                    }
                    totalMoneyPerClient += decorationCountPerClient * decorationPrice;
                    totalCountPerClient += decorationCountPerClient;
                    decorationType = Console.ReadLine();
                }
                if (totalCountPerClient % 2 == 0)
                {
                    totalMoneyPerClient *= 0.8;
                }
                Console.WriteLine($"You purchased {totalCountPerClient} items for {totalMoneyPerClient:f2} leva.");
                totalMoney += totalMoneyPerClient;
                totalCount += totalCountPerClient;
            }
            double averageMoney = totalMoney / clientNumber;
            Console.WriteLine($"Average bill per client is: {averageMoney:f2} leva.");
        }
    }
}
