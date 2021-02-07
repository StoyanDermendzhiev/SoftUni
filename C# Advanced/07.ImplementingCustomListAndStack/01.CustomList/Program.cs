using System;

namespace _01.CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>();

            list.Add(2);
            list.Add(5);
            list.Add(6);
            list.Contains(5);
            list.RemoveAt(0);
            list.Swap(0, 1);
            Console.WriteLine(list.Count);
            list.Insert(1, 10);
        }
    }
}
