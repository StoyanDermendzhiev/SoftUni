using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.GenericSwapMethodString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Box<string>> data = new List<Box<string>>();

            for (int i = 0; i < n; i++)
            {
                Box<string> box = new Box<string>(Console.ReadLine());
                data.Add(box);
            }

            int[] indexes = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();

            Swap(data, indexes[0], indexes[1]);

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
