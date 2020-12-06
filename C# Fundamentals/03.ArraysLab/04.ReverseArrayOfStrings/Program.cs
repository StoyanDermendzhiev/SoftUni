using System;
using System.Linq;

namespace _04.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
                     
            Console.WriteLine(string.Join(" ", input.Reverse()));
        }
    }
}
