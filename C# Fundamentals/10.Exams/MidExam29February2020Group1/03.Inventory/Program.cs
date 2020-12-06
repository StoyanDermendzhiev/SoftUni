using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> collectingItems = Console.ReadLine()
                                                  .Split(", ")
                                                  .ToList();
            string input = Console.ReadLine();
            string item = string.Empty;

            while (input != "Craft!")
            {
                string[] command = input.Split(" - ")
                                        .ToArray();
                string currentCommand = command[0];

                if (currentCommand == "Collect")
                {
                    item = command[1];

                    if (!collectingItems.Contains(item))
                    {
                        collectingItems.Add(item);
                    }
                }
                else if (currentCommand == "Drop")
                {
                    item = command[1];

                    if (collectingItems.Contains(item))
                    {
                        collectingItems.Remove(item);
                    }
                }
                else if (currentCommand == "Combine Items")
                {
                    string[] combineItems = command[1].Split(":")
                                                      .ToArray();
                    item = combineItems[0];
                    string newItem = combineItems[1];

                    if (collectingItems.Contains(item))
                    {
                        int index = collectingItems.IndexOf(item);
                        collectingItems.Insert(index + 1, newItem);
                    }
                }
                else if (currentCommand == "Renew")
                {
                    item = command[1];

                    if (collectingItems.Contains(item))
                    {
                        collectingItems.Remove(item);
                        collectingItems.Add(item);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", collectingItems));
        }
    }
}
