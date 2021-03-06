﻿using System;
using System.Linq;

namespace _02.Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] createCommandItems = Console.ReadLine()
                                            .Split()
                                            .Skip(1)
                                            .ToArray();

            ListyIterator<string> list = new ListyIterator<string>(createCommandItems);

            string command = Console.ReadLine();

            while (command != "END")
            {
                switch (command)
                {
                    case "Move":
                        Console.WriteLine(list.Move());
                        break;
                    case "Print":
                        list.Print();
                        break;
                    case "HasNext":
                        Console.WriteLine(list.HasNext());
                        break;
                    case "PrintAll":
                        list.PrintAll();
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
