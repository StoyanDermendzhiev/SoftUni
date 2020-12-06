using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.TheFinalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wordsCollection = Console.ReadLine()
                                                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                  .ToList();
            string input = Console.ReadLine();

            while (input != "Stop")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToArray();
                string currentCommand = command[0];

                if (currentCommand == "Delete")
                {
                    int index = int.Parse(command[1]);
                    if (index >= -1 && index < wordsCollection.Count - 1)
                    {
                        wordsCollection.RemoveAt(index + 1);
                    }
                }
                else if (currentCommand == "Swap")
                {
                    string word1 = command[1];
                    string word2 = command[2];
                    int indexWord1 = wordsCollection.IndexOf(word1);
                    int indexWord2 = wordsCollection.IndexOf(word2);

                    if (wordsCollection.Contains(word1) && wordsCollection.Contains(word2))
                    {
                        wordsCollection[indexWord1] = word2;
                        wordsCollection[indexWord2] = word1;
                    }
                }
                else if (currentCommand == "Put")
                {
                    string word = command[1];
                    int index = int.Parse(command[2]);

                    if (index > 0 && index <= wordsCollection.Count)
                    {
                        if (index == wordsCollection.Count)
                        {
                            wordsCollection.Add(word);
                        }
                        else
                        {
                            wordsCollection.Insert(index - 1, word);
                        }
                    }
                }
                else if (currentCommand == "Sort")
                {
                    wordsCollection.Sort();
                }
                else if (currentCommand == "Replace")
                {
                    string word1 = command[1];
                    string word2 = command[2];

                    if (wordsCollection.Contains(word2))
                    {
                        wordsCollection[wordsCollection.IndexOf(word2)] = word1;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", wordsCollection));
        }
    }
}
