using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> shotTargets = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse)
                                        .ToList();
            string command = Console.ReadLine();
            int shotTargetsCount = 0;

            while (command != "End")
            {
                int targetIndex = int.Parse(command);

                if (targetIndex < 0 || targetIndex > shotTargets.Count - 1)
                {
                    command = Console.ReadLine();
                    continue;
                }

                int shotTargetValue = shotTargets[targetIndex];

                for (int i = 0; i < shotTargets.Count; i++)
                {
                    if (i == targetIndex)
                    {
                        shotTargets[targetIndex] = -1;
                    }
                    else if (shotTargets[i] > -1)
                    {
                        if (shotTargets[i] > shotTargetValue)
                        {
                            shotTargets[i] -= shotTargetValue;
                        }
                        else if (shotTargets[i] <= shotTargetValue)
                        {
                            shotTargets[i] += shotTargetValue;
                        }
                    }
                }

                shotTargetsCount++;
                command = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {shotTargetsCount} -> {string.Join(" ", shotTargets)}");
        }
    }
}
