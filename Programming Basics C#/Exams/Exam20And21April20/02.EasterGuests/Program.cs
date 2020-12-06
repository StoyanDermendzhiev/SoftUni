using System;
using System.Runtime.CompilerServices;

namespace _02.EasterGuests
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestsNumber = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double numberOfEasterBreads = Math.Ceiling(1.0 * guestsNumber / 3);
            int numberOfEggs = guestsNumber * 2;
            double totalMoney = numberOfEasterBreads * 4 + numberOfEggs * 0.45;
            if (totalMoney <= budget)
            {
                Console.WriteLine($"Lyubo bought {numberOfEasterBreads} Easter bread and {numberOfEggs} eggs.");
                Console.WriteLine($"He has {budget - totalMoney:f2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {totalMoney - budget:f2} lv. more.");
            }
        }
    }
}
