using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.EasterShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> plannedShops = Console.ReadLine()
                                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                               .ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                                          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToArray();
                string currentCommand = command[0];

                if (currentCommand == "Include")
                {
                    plannedShops.Add(command[1]);
                }
                else if (currentCommand == "Visit")
                {
                    string secondCommand = command[1];
                    int numberOfShops = int.Parse(command[2]);

                    if (numberOfShops >= 0 && numberOfShops < plannedShops.Count)
                    {
                        if (secondCommand == "first")
                        {
                            plannedShops.RemoveRange(0, numberOfShops);
                        }
                        else if (secondCommand == "last")
                        {
                            plannedShops.Reverse();
                            plannedShops.RemoveRange(0, numberOfShops);
                            plannedShops.Reverse();
                        }
                    }
                }
                else if (currentCommand == "Prefer")
                {
                    int shopIndex1 = int.Parse(command[1]);
                    int shopIndex2 = int.Parse(command[2]);
                    bool isValidIndexes = shopIndex1 >= 0 &&
                                          shopIndex1 < plannedShops.Count &&
                                          shopIndex2 >= 0 &&
                                          shopIndex2 < plannedShops.Count;

                    if (isValidIndexes)
                    {
                        string currentShop = plannedShops[shopIndex1];
                        plannedShops[shopIndex1] = plannedShops[shopIndex2];
                        plannedShops[shopIndex2] = currentShop;
                    }
                }
                else if (currentCommand == "Place")
                {
                    string shop = command[1];
                    int shopIndex = int.Parse(command[2]);

                    if (shopIndex >= 0 && shopIndex < plannedShops.Count)
                    {
                        plannedShops.Insert(shopIndex + 1, shop);
                    }
                }
            }

            Console.WriteLine("Shops left:");
            Console.WriteLine(string.Join(" ", plannedShops));
        }
    }
}
