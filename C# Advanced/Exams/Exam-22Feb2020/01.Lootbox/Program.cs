using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstBox = new Queue<int>(Console.ReadLine()
                                                 .Split()
                                                 .Select(int.Parse));
            Stack<int> secondBox = new Stack<int>(Console.ReadLine()
                                                 .Split()
                                                 .Select(int.Parse));

            int claimedItems = 0;

            while (firstBox.Any() && secondBox.Any())
            {
                int firstBoxItem = firstBox.Peek();
                int secondBoxItem = secondBox.Pop();
                int sum = firstBoxItem + secondBoxItem;

                if (sum % 2 == 0)
                {
                    claimedItems += sum;
                    firstBox.Dequeue();
                }
                else
                {
                    firstBox.Enqueue(secondBoxItem);
                }
            }

            if (!firstBox.Any())
            {
                Console.WriteLine("First lootbox is empty");
            }

            if (!secondBox.Any())
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (claimedItems >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {claimedItems}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {claimedItems}");
            }
        }
    }
}
