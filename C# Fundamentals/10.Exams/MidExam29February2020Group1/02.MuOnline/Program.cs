using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dungeonsRoom = Console.ReadLine()
                                               .Split("|")
                                               .ToList();
            int health = 100;
            int bitcoins = 0;

            for (int roomNumber = 1; roomNumber <= dungeonsRoom.Count; roomNumber++)
            {
                string[] room = dungeonsRoom[roomNumber - 1]
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .ToArray();
                string command = room[0];
                int amount = int.Parse(room[1]);

                if (command == "potion")
                {
                    health += amount;
                    if (health > 100)
                    {
                        amount = amount - (health - 100);
                        health = 100;
                    }
                    Console.WriteLine($"You healed for {amount} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (command == "chest")
                {
                    bitcoins += amount;
                    Console.WriteLine($"You found {amount} bitcoins.");
                }
                else
                {
                    health -= amount;

                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {roomNumber}");
                        return;
                    }
                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
