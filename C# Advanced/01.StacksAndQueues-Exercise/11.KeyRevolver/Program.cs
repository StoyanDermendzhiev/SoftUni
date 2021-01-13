using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();
            int[] locks = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();
            int intelligenceValue = int.Parse(Console.ReadLine());

            var locksQueue = new Queue<int>(locks);
            var bulletsStack = new Stack<int>(bullets);

            int totalPrice = 0;
            int totalShoots = 0;

            while (locksQueue.Count > 0 && bulletsStack.Count > 0)
            {
                if (bulletsStack.Pop() <= locksQueue.Peek())
                {
                    Console.WriteLine("Bang!");
                    locksQueue.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                totalPrice += bulletPrice;
                totalShoots++;

                if (totalShoots % gunBarrelSize == 0 && bulletsStack.Count != 0)
                {
                    Console.WriteLine("Reloading!");
                } 
            }

            if (locksQueue.Count == 0)
            {
                Console.WriteLine($"{bulletsStack.Count} bullets left. Earned ${intelligenceValue - totalPrice}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
            }
        }
    }
}
