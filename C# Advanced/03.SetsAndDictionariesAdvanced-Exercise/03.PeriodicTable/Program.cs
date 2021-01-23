using System;
using System.Collections.Generic;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int lineCount = int.Parse(Console.ReadLine());

            SortedSet<string> uniqueElements = new SortedSet<string>(); 

            for (int i = 0; i < lineCount; i++)
            {
                string[] inputElements = Console.ReadLine().Split();

                foreach (var element in inputElements)
                {
                    uniqueElements.Add(element);
                }
            }

            Console.WriteLine(string.Join(" ", uniqueElements));
        }
    }
}
