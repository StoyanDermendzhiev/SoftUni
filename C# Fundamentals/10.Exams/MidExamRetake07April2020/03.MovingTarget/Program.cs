using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();
            string input = Console.ReadLine();

            while (input != "End")
            {
                List<string> command = input
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .ToList();
                string commandWord = command[0];
                int commandIndex = int.Parse(command[1]);

                if (commandWord == "Shoot")
                {
                    if (commandIndex >= 0 && commandIndex <= targets.Count - 1)
                    {
                        int power = int.Parse(command[2]);
                        targets[commandIndex] -= power;

                        if (targets[commandIndex] <= 0)
                        {
                            targets.RemoveAt(commandIndex);
                        }
                    }
                }
                else if (commandWord == "Add")
                {
                    if (commandIndex >= 0 && commandIndex <= targets.Count - 1)
                    {
                        int value = int.Parse(command[2]);
                        targets.Insert(commandIndex, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (commandWord == "Strike")
                {
                    int raduis = int.Parse(command[2]);

                    if ((commandIndex - raduis >= 0) && (commandIndex + raduis <= targets.Count - 1))
                    {
                        targets.RemoveRange(commandIndex - raduis, raduis * 2 + 1);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join("|", targets));
        }
    }
}
