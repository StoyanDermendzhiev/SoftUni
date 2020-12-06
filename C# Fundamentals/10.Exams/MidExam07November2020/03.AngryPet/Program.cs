using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.AngryPet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> priceRatings = Console.ReadLine()
                                            .Split()
                                            .Select(int.Parse)
                                            .ToList();
            int entryPoint = int.Parse(Console.ReadLine());
            string typeOfItems = Console.ReadLine();
            string typeOfPriceRatings = Console.ReadLine();

            int entryPointPriceRating = priceRatings[entryPoint];
            
            int leftSum = 0;

            for (int i = 0; i < entryPoint; i++)
            {
                int currentItem = priceRatings[i];
                leftSum += GetTheBreakingItems(currentItem, 
                                               typeOfItems, 
                                               typeOfPriceRatings, 
                                               entryPointPriceRating);
            }

            int rightSum = 0;

            for (int i = entryPoint; i < priceRatings.Count; i++)
            {
                int currentItem = priceRatings[i];
                rightSum += GetTheBreakingItems(currentItem, 
                                                typeOfItems, 
                                                typeOfPriceRatings,
                                                entryPointPriceRating);
            }

            string position = string.Empty;
            int sumOfPriceRatings = 0;

            if (leftSum >= rightSum)
            {
                position = "Left";
                sumOfPriceRatings = leftSum;
            }
            else
            {
                position = "Right";
                sumOfPriceRatings = rightSum;
            }

            Console.WriteLine($"{position} - {sumOfPriceRatings}");
        }

        public static int GetTheBreakingItems(int currentItem, 
                                              string typeOfItems, 
                                              string typeOfPriceRatings, 
                                              int entryPointPriceRating)
        {
            int sum = 0;
            
            if (typeOfItems == "cheap")
            {
                if (typeOfPriceRatings == "positive")
                {
                    if (currentItem > 0 && currentItem < entryPointPriceRating)
                    {
                        sum = currentItem;
                    }
                }
                else if (typeOfPriceRatings == "negative")
                {
                    if (currentItem < 0 && currentItem < entryPointPriceRating)
                    {
                        sum = currentItem;
                    }
                }
                else if (typeOfPriceRatings == "all")
                {
                    if (currentItem < entryPointPriceRating)
                    {
                        sum = currentItem;
                    }
                }
            }
            else if (typeOfItems == "expensive")
            {
                if (typeOfPriceRatings == "positive")
                {
                    if (currentItem > 0 && currentItem >= entryPointPriceRating)
                    {
                        sum = currentItem;
                    }
                }
                else if (typeOfPriceRatings == "negative")
                {
                    if (currentItem < 0 && currentItem >= entryPointPriceRating)
                    {
                        sum = currentItem;
                    }
                }
                else if (typeOfPriceRatings == "all")
                {
                    if (currentItem >= entryPointPriceRating)
                    {
                        sum = currentItem;
                    }
                }
            }
            return sum;
        }
    }
}
