using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> drumSet = Console.ReadLine()
                                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToList();
            string command = Console.ReadLine();

            List<int> currentDrumSet = new List<int>(drumSet.Count);

            foreach (int item in drumSet)
            {
                currentDrumSet.Add(item);
            }

            while (command != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(command);

                for (int i = 0; i < currentDrumSet.Count; i++)
                {
                    int currentDrum = currentDrumSet[i];
                    currentDrum -= hitPower;

                    if (currentDrum <= 0)
                    {
                        if (savings >= drumSet[i] * 3)
                        {
                            currentDrum = drumSet[i];
                            savings -= currentDrum * 3;
                        }
                    }

                    currentDrumSet[i] = currentDrum;
                }

                command = Console.ReadLine();
            }

            currentDrumSet.RemoveAll(x => x <= 0);

            Console.WriteLine(string.Join(" ", currentDrumSet));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
