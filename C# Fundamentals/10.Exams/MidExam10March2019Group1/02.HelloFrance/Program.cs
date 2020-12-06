using System;
using System.Collections.Generic;

namespace _02.HelloFrance
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] itemsCollection = Console.ReadLine()
                                              .Split("|");
            double budget = double.Parse(Console.ReadLine());

            double currentBudget = budget;
            List<double> pricesOfItems = new List<double>();

            for (int i = 0; i < itemsCollection.Length; i++)
            {
                string[] currentItem = itemsCollection[i].Split("->");
                string typeOfCurrentItem = currentItem[0];
                double priceOfCurrentItem = double.Parse(currentItem[1]);

                bool canBuyIt = (typeOfCurrentItem == "Clothes" && priceOfCurrentItem <= 50) ||
                                (typeOfCurrentItem == "Shoes" && priceOfCurrentItem <= 35) ||
                                (typeOfCurrentItem == "Accessories" && priceOfCurrentItem <= 20.50);

                if (canBuyIt)
                {
                    if (currentBudget >= priceOfCurrentItem)
                    {
                        currentBudget -= priceOfCurrentItem;
                        pricesOfItems.Add(priceOfCurrentItem * 1.4);
                    }
                }
            }

            double profit = 0;

            for (int i = 0; i < pricesOfItems.Count; i++)
            {
                profit += pricesOfItems[i] - pricesOfItems[i] / 1.4;

                if (i < pricesOfItems.Count - 1)
                {
                    Console.Write($"{pricesOfItems[i]:f2} ");
                }
                else
                {
                    Console.WriteLine($"{pricesOfItems[i]:f2}");
                }
            }

            Console.WriteLine($"Profit: {profit:f2}");

            if (profit + budget + currentBudget >= 150)
            {
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }
        }
    }
}
