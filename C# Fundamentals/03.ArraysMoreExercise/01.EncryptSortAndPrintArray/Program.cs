using System;
using System.Linq;

namespace _01.EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] output = new int[n];

            for (int line = 0; line < n; line++)
            {
                int sum = 0;
                string input = Console.ReadLine();
                for (int index = 0; index < input.Length; index++)
                {
                    bool isVowel = "aeiouAEIOU".IndexOf(input[index]) >= 0;
                    if (isVowel)
                    {
                        sum += input[index] * input.Length;
                    }
                    else
                    {
                        sum += input[index] / input.Length;
                    }
                }
                output[line] = sum;
            }
            Array.Sort(output);
            Console.WriteLine(string.Join(Environment.NewLine,output));
        }
    }
}
