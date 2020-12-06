using System;

namespace _04.EasterShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsAvailable = int.Parse(Console.ReadLine());
            int soldEggs = 0;
            for (int i = 1; i < 10000; i++)
            {
                string command = Console.ReadLine();
                if (command == "Close")
                {
                    Console.WriteLine("Store is closed!");
                    Console.WriteLine($"{soldEggs} eggs sold.");
                    break;
                }
                int buyOrFillEggs = int.Parse(Console.ReadLine());
                if (command == "Buy")
                {
                    if (buyOrFillEggs > eggsAvailable)
                    {
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {eggsAvailable}.");
                        break;
                    }
                    eggsAvailable -= buyOrFillEggs;
                    soldEggs += buyOrFillEggs;
                }
                else if (command == "Fill")
                {
                    eggsAvailable += buyOrFillEggs;
                }
            }
        }
    }
}
