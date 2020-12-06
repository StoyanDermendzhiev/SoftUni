using System;
using System.Linq;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            while (inputString != "end")
            {
                string reverseWord = new string (inputString.Reverse().ToArray());

                Console.WriteLine($"{inputString} = {reverseWord}");

                inputString = Console.ReadLine();
            }
        }
    }
}
