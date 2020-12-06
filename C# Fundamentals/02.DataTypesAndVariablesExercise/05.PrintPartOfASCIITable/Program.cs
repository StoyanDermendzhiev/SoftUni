using System;

namespace _05.PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int lastIndex = int.Parse(Console.ReadLine());

            for (int input = startIndex; input <= lastIndex; input++)
            {
                char index = (char)input;
                Console.Write($"{index} ");
            }
        }
    }
}
