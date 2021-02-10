using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.GenericCountMethodDouble
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Box<double>> data = new List<Box<double>>();

            for (int i = 0; i < n; i++)
            {
                Box<double> box = new Box<double>(double.Parse(Console.ReadLine()));
                data.Add(box);
            }

            Box<double> element = new Box<double>(double.Parse(Console.ReadLine()));

            int count = GetCountOfGreaterElements(data, element);

            Console.WriteLine(count);
        }

        public static int GetCountOfGreaterElements<T>(List<Box<T>> boxes, Box<T> box)
            where T: IComparable
        {
            int count = 0;

            foreach (Box<T> item in boxes)
            {
                int compare = item.Value.CompareTo(box.Value);

                if (compare > 0)
                {
                    count++;
                }
            }

            return count;
        }

        public static void Swap<T>(List<T> data, int index1, int index2)
            where T: IComparable
        {
            T current = data[index1];
            data[index1] = data[index2];
            data[index2] = current;
        }
    }
}
