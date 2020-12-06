using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = string.Empty;

            if (input.Length % 2 == 0)
            {
                output = GetMiddleCharsEvenString(input);
            }
            else
            {
                output = GetMiddleCharOddString(input);
            }

            Console.WriteLine(output);
        }

        private static string GetMiddleCharOddString(string input)
        {
            int index = input.Length / 2;
            string output = input.Substring(index, 1);
            return output;
        }

        private static string GetMiddleCharsEvenString(string input)
        {
            int index = input.Length / 2;
            string output = input.Substring(index - 1, 2);
            return output;
        }
    }
}
