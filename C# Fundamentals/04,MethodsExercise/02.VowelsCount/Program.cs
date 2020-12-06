using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            VowelsCount(input);
        }

        private static void VowelsCount(string input)
        {
            int vowelCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if ("aeiouAEIOU".IndexOf(c) >= 0)
                {
                    vowelCount++;
                }
            }
            Console.WriteLine(vowelCount);
        }
    }
}
