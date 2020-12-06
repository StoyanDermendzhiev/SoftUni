using System;
using System.Linq;

namespace _02.ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();
            string[] input = Console.ReadLine().Split();

            while (input[0] != "end")
            {
                if (input[0] == "swap")
                {
                    int commonElement = arr[int.Parse(input[1])];
                    arr[int.Parse(input[1])] = arr[int.Parse(input[2])];
                    arr[int.Parse(input[2])] = commonElement;
                }
                else if (input[0] == "multiply")
                {
                    arr[int.Parse(input[1])] = arr[int.Parse(input[1])] * arr[int.Parse(input[2])];
                }
                else if (input[0] == "decrease")
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = arr[i] - 1;
                    }
                }
                input = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
