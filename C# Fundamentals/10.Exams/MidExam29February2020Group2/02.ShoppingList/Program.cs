using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine()
                                    .Split("!")
                                    .ToList();
            string input = Console.ReadLine();

            while (input != "Go Shopping!")
            {
                string[] command = input
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .ToArray();
                string currentCommand = command[0];
                string currentItem = command[1];

                if (currentCommand == "Urgent")
                {
                    if (!groceries.Contains(currentItem))
                    {
                        groceries.Insert(0, currentItem);
                    }
                }

                else if (currentCommand == "Unnecessary")
                {
                    if (groceries.Contains(currentItem))
                    {
                        groceries.Remove(currentItem);
                    }
                }

                else if (currentCommand == "Correct")
                {
                    string newItem = command[2];

                    for (int i = 0; i < groceries.Count; i++)
                    {
                        if (groceries[i] == currentItem)
                        {
                            groceries[i] = newItem;
                        }
                    }
                }

                else if (currentCommand == "Rearrange")
                {
                    if (groceries.Contains(currentItem))
                    {
                        groceries.Remove(currentItem);
                        groceries.Add(currentItem);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}
