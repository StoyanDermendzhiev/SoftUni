using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.EasterGifts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> plannedGifts = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string input = Console.ReadLine();

            while (input != "No Money")
            {
                string[] command = input.Split()
                                        .ToArray();
                string currentCommand = command[0];
                string gift = command[1];

                if (currentCommand == "OutOfStock")
                {
                    for (int i = 0; i < plannedGifts.Count; i++)
                    {
                        if (plannedGifts[i] == gift)
                        {
                            plannedGifts[i] = "None";
                        }
                    }
                }
                else if (currentCommand == "Required")
                {
                    int index = int.Parse(command[2]);

                    if (index >= 0 && index < plannedGifts.Count)
                    {
                        plannedGifts[index] = gift;
                    }
                }
                else if (currentCommand == "JustInCase")
                {
                    plannedGifts[plannedGifts.Count - 1] = gift;
                }

                input = Console.ReadLine();
            }

            plannedGifts.RemoveAll(x => x == "None");

            Console.WriteLine(string.Join(" ", plannedGifts));
        }
    }
}
