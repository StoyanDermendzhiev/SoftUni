using System;
using System.Linq;

namespace _04.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();
            int k = input.Length / 4;
            int[] output = new int[k * 2];

            for (int left = 0; left < input.Length / 2 - k; left++)
            {
                output[k - left - 1] = input[left] + input[input.Length / 2 - 1 - left];
            }
            for (int right = 2 * k; right <= input.Length - 1 - k; right++)
            {
                output[right - k] = input[right] + input[input.Length - right + 2 * k - 1];
            }
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
