using System;

namespace _02.AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string inputString = Console.ReadLine();

            char startingChar = firstChar;
            char endingChar = secondChar;

            if (firstChar > secondChar)
            {
                startingChar = secondChar;
                endingChar = firstChar;
            }

            int sum = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] > startingChar && inputString[i] < endingChar)
                {
                    sum += inputString[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
