using System;

namespace _01.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                                    .Split();

            Random rnd = new Random();

            for (int oldPosition = 0; oldPosition < input.Length; oldPosition++)
            {
                int newPosition = rnd.Next(0, input.Length);
                string word = input[oldPosition];
                input[oldPosition] = input[newPosition];
                input[newPosition] = word;
            }

            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
