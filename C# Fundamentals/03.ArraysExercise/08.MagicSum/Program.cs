using System;
using System.Linq;

namespace _08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToArray();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputArr.Length; i++)
            {
                for (int j = i+1; j < inputArr.Length; j++)
                {
                    if (inputArr[i] + inputArr[j] == number)
                    {
                        Console.WriteLine(inputArr[i] + " " + inputArr[j]);
                    }
                }
            }
        
        }
    }
}
