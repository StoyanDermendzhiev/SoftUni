﻿using System;
using System.IO;

namespace _01.OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../input.txt"))
            {
                string currentRow = reader.ReadLine();
                int row = 0;

                while (currentRow != null)
                {
                    if (row % 2 != 0)
                    {
                        Console.WriteLine(currentRow);
                    }

                    currentRow = reader.ReadLine();
                    row++;
                }

            }
        }
    }
}
