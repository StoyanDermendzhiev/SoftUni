using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.GenericSwapMethodInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Box<int>> data = new List<Box<int>>();

            for (int i = 0; i < n; i++)
            {
                Box<int> box = new Box<int>(int.Parse(Console.ReadLine()));
                data.Add(box);
            }

            int[] indexes = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, data));
        }

        public static void Swap<T>(List<T> data, int index1, int index2)
        {
            T current = data[index1];
            data[index1] = data[index2];
            data[index2] = current;
        }
    }
}
