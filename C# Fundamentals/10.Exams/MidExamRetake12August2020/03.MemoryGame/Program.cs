using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToList();

            string command = Console.ReadLine();
            int movesCount = 0;

            while (command != "end")
            {
                int[] indexes = command
                                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

                int index0 = indexes[0];
                int index1 = indexes[1];

                bool isCheat = index0 == index1 ||
                               index0 > input.Count - 1 ||
                               index1 > input.Count - 1 ||
                               index0 < 0 ||
                               index1 < 0;
                
                movesCount++;

                if (isCheat)
                {
                    int middleIndex = input.Count / 2;
                    input.Insert(middleIndex, $"-{movesCount}a");
                    input.Insert(middleIndex +1, $"-{movesCount}a");

                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    command = Console.ReadLine();
                    continue;
                }

                if (input[index0] == input[index1])
                {
                    string matchIndex = input[index0];
                    input.RemoveAll(i => i == matchIndex);
                    Console.WriteLine($"Congrats! You have found matching elements - {matchIndex}!");
                }
                else
                {
                    Console.WriteLine("Try again!");
                }

                if (input.Count == 0)
                {
                    Console.WriteLine($"You have won in {movesCount} turns!");
                    return;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
