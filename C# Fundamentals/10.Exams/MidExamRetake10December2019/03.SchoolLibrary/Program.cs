using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SchoolLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shelf = Console.ReadLine()
                                        .Split("&")
                                        .ToList();
            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] command = input.Split(" | ")
                                        .ToArray();
                string currentCommand = command[0];

                if (currentCommand == "Add Book")
                {
                    if (!shelf.Contains(command[1]))
                    {
                        shelf.Insert(0, command[1]);
                    }
                }
                else if (currentCommand == "Take Book")
                {
                    if (shelf.Contains(command[1]))
                    {
                        shelf.Remove(command[1]);
                    }
                }
                else if (currentCommand == "Swap Books")
                {
                    if (shelf.Contains(command[1]) && shelf.Contains(command[2]))
                    {
                        int index1 = shelf.IndexOf(command[1]);
                        int index2 = shelf.IndexOf(command[2]);
                        shelf[index1] = command[2];
                        shelf[index2] = command[1];
                    }
                }
                else if (currentCommand == "Insert Book")
                {
                    shelf.Add(command[1]);
                }
                else if (currentCommand == "Check Book")
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index < shelf.Count)
                    {
                        Console.WriteLine(shelf[index]);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", shelf));
        }
    }
}
