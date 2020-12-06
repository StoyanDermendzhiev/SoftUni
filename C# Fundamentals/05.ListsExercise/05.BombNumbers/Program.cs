﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> bombNumber = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber[0])
                {
                    int startIndex = i - bombNumber[1];
                    int endIndex = i + bombNumber[1];
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > numbers.Count - 1)
                    {
                        endIndex = numbers.Count - 1;
                    }

                    int endIndexToRemove = endIndex - startIndex + 1;
                    numbers.RemoveRange(startIndex, endIndexToRemove);

                    i = startIndex - 1;
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
