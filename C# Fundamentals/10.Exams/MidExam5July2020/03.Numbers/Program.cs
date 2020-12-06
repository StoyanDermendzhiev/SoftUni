using System;
using System.Linq;

namespace _03.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

            double averageValue = (double)input.Sum() / input.Length;
            string biggerNumbers = string.Empty;
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > averageValue)
                {
                    biggerNumbers += input[i] + " ";
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("No");
                return;
            }

            int[] output = biggerNumbers.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse)
                                        .ToArray();
            Array.Sort(output);
            Array.Reverse(output);

            if (output.Length > 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(output[i] + " ");
                }
            }
            else
            {
                Console.WriteLine(string.Join(" ", output));
            }
        }
    }
}
