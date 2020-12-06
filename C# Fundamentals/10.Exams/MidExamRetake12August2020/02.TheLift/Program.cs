using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int waitingPeople = int.Parse(Console.ReadLine());
            List<int> liftWagons = Console.ReadLine()
                                          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .Select(int.Parse)
                                          .ToList();
            int wagonCapacity = 4;

            for (int i = 0; i < liftWagons.Count; i++)
            {
                int emptyWagonSpace = wagonCapacity - liftWagons[i];

                if (waitingPeople - emptyWagonSpace < 0)
                {
                    liftWagons[i] += waitingPeople;
                }
                else
                {
                    liftWagons[i] += emptyWagonSpace;
                }

                waitingPeople -= emptyWagonSpace;
            }

            if (waitingPeople <= 0 && liftWagons.Sum() < wagonCapacity * liftWagons.Count)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", liftWagons));
            }
            else if (waitingPeople > 0 && liftWagons.Sum() == wagonCapacity * liftWagons.Count)
            {
                Console.WriteLine($"There isn't enough space! {waitingPeople} people in a queue!");
                Console.WriteLine(string.Join(" ", liftWagons));
            }
            else if (waitingPeople == 0 && liftWagons.Sum() == wagonCapacity * liftWagons.Count)
            {
                Console.WriteLine(string.Join(" ", liftWagons));
            }
        }
    }
}
