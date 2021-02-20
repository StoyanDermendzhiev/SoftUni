using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.TheFightForGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWaves = int.Parse(Console.ReadLine());

            var plates = new Queue<int>(Console.ReadLine()
                                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                               .Select(int.Parse)
                                               .ToArray());

            bool isDestroyed = false;

            for (int i = 1; i <= numberOfWaves; i++)
            {
                var orcs = new Stack<int>(Console.ReadLine()
                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray());

                if (i % 3 == 0)
                {
                    int newPlate = int.Parse(Console.ReadLine());
                    plates.Enqueue(newPlate);
                }


                while (orcs.Any())
                {
                    int currentOrc = orcs.Pop();
                    int currentPlate = plates.Dequeue();

                    if (currentOrc > currentPlate)
                    {
                        orcs.Push(currentOrc - currentPlate);
                    }
                    else if (currentPlate > currentOrc)
                    {
                        currentPlate -= currentOrc;
                        plates.Enqueue(currentPlate);

                        for (int j = 0; j < plates.Count - 1; j++)
                        {
                            int plate = plates.Dequeue();
                            plates.Enqueue(plate);
                        }
                    }

                    if (plates.Count == 0)
                    {
                        isDestroyed = true;
                        break;
                    }
                }

                if (isDestroyed)
                {
                    Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                    Console.WriteLine($"Orcs left: {string.Join(", ", orcs)}");
                    return;
                }
            }

            Console.WriteLine("The people successfully repulsed the orc's attack.");
            Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
        }
    }
}
