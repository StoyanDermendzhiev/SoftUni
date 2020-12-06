using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputLine = Console.ReadLine()
                                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                            .ToList();
            string input = Console.ReadLine();

            while (input != "3:1")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = command[0];
                int index = int.Parse(command[1]);

                if (currentCommand == "merge")
                {
                    int endIndex = int.Parse(command[2]);

                    if (index < 0)
                    {
                        index = 0;
                    }

                    if (endIndex >= inputLine.Count)
                    {
                        endIndex = inputLine.Count - 1;
                    }

                    if (index >= endIndex)
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    string mergeIndexes = string.Empty;

                    for (int i = index; i <= endIndex; i++)
                    {
                        mergeIndexes += inputLine[i];
                    }

                    inputLine.RemoveRange(index, endIndex - index + 1);
                    inputLine.Insert(index, mergeIndexes);
                }
                else if (currentCommand == "divide")
                {
                    int partitions = int.Parse(command[2]);
                    string current = inputLine[index];

                    inputLine.RemoveAt(index);

                    string dividedString = string.Empty;
                    int count = 0;
                    int dividedLenght = (current.Length) / partitions;

                    for (int i = 0; i < current.Length; i++)
                    {
                        dividedString += current[i];

                        if ((i + 1) % dividedLenght == 0)
                        {
                            inputLine.Insert(index + count, dividedString);
                            count++;
                            dividedString = string.Empty;
                        }

                        if (current.Length % 2 != 0 && count == partitions)
                        {
                            inputLine[count - 1] += current[current.Length - 1];
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", inputLine));
        }
    }
}
