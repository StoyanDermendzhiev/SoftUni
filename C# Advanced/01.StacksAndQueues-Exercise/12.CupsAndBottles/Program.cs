using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsCapacity = Console.ReadLine()
                                        .Split()
                                        .Select(int.Parse)
                                        .ToArray();
            int[] filledBottles = Console.ReadLine()
                                        .Split()
                                        .Select(int.Parse)
                                        .ToArray();

            var cups = new Queue<int>(cupsCapacity);
            var bottles = new Stack<int>(filledBottles);

            int wastedWater = 0;

            while (cups.Count != 0 && bottles.Count != 0)
            {
                int currentCup = cups.Dequeue();
                int currentBottle = bottles.Pop();

                if (currentCup > currentBottle)
                {
                    while (currentCup > 0)
                    {
                        currentCup -= currentBottle;
                        if (currentCup <= 0)
                        {
                            wastedWater += Math.Abs(currentCup);
                            break;
                        }
                        else
                        {
                            currentBottle = bottles.Pop();
                        }
                    }
                }
                else
                {
                    wastedWater += currentBottle - currentCup;
                }
            }

            if (cups.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
