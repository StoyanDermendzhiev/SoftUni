using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class PetrolPump
    {
        public PetrolPump(int petrolAmount, int distance, int pumpIndex)
        {
            PetrolAmount = petrolAmount;
            Distance = distance;
            PumpIndex = pumpIndex;
        }

        public int PetrolAmount { get; set; }
        public int Distance { get; set; }
        public int PumpIndex { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var queue = new Queue<PetrolPump>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                                     .Split()
                                     .Select(int.Parse)
                                     .ToArray();

                PetrolPump petrolPump = new PetrolPump(input[0], input[1], i);

                queue.Enqueue(petrolPump);
            }

            int totalFuel = 0;

            for (int i = 0; i < n; i++)
            {
                PetrolPump currentPetrolPump = queue.Dequeue();

                totalFuel += currentPetrolPump.PetrolAmount;

                if (totalFuel >= currentPetrolPump.Distance)
                {
                    totalFuel -= currentPetrolPump.Distance;
                }
                else
                {
                    totalFuel = 0;
                    i = -1;
                }

                queue.Enqueue(currentPetrolPump);
            }

            Console.WriteLine(queue.Dequeue().PumpIndex);
        }
    }
}
