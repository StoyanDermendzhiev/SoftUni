using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> bombEffects = new Queue<int>(Console.ReadLine()
                                                    .Split(", ")
                                                    .Select(int.Parse));
            Stack<int> bombCasings = new Stack<int>(Console.ReadLine()
                                                    .Split(", ")
                                                    .Select(int.Parse));
            SortedDictionary<string, int> bombs = new SortedDictionary<string, int>()
            {
                { "Datura Bombs", 0 },
                { "Cherry Bombs", 0},
                { "Smoke Decoy Bombs", 0}
            };

            bool isFilled = false;

            while (bombCasings.Any() && bombEffects.Any())
            {
                int currentBombCasing = bombCasings.Pop();
                int sum = currentBombCasing + bombEffects.Peek();

                switch (sum)
                {
                    case 40:
                        bombs["Datura Bombs"]++;
                        bombEffects.Dequeue();
                        break;
                    case 60:
                        bombs["Cherry Bombs"]++;
                        bombEffects.Dequeue();
                        break;
                    case 120:
                        bombs["Smoke Decoy Bombs"]++;
                        bombEffects.Dequeue();
                        break;
                    default:
                        bombCasings.Push(currentBombCasing - 5);
                        break;
                }

                isFilled = bombs.Values.All(b => b > 2);

                if (isFilled)
                {
                    Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
                    break;
                }
            }

            if (!isFilled)
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (bombEffects.Any())
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffects)}");
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }

            if (bombCasings.Any())
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasings)}");
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }

            foreach (var bomb in bombs)
            {
                Console.WriteLine($"{bomb.Key}: {bomb.Value}");
            }
        }
    }
}
