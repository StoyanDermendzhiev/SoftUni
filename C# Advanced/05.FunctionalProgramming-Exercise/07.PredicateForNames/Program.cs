﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            names = names.Where(name => name.Length <= n).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
