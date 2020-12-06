using System;

namespace _01.CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int currentEnergy = initialEnergy;
            int winsCount = 0;

            while (command != "End of battle")
            {
                int distance = int.Parse(command);

                if (distance > currentEnergy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {winsCount} won battles and {currentEnergy} energy");
                    return;
                }

                currentEnergy -= distance;
                winsCount++;

                if (winsCount % 3 == 0)
                {
                    currentEnergy += winsCount;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Won battles: {winsCount}. Energy left: {currentEnergy}");
        }
    }
}
