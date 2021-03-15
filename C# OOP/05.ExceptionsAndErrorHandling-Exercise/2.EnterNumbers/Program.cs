using System;

namespace _2.EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;

            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                try
                {
                    numbers[i] = ReadNumber(start, end);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    i = -1;
                    start = 1;
                    continue;
                }

                start = numbers[i];
            }

            Console.WriteLine($"Your numbers: {string.Join(", ", numbers)}");
        }

        static int ReadNumber(int start, int end)
        {
            string input = Console.ReadLine();

            foreach (var ch in input)
            {
                if (!char.IsDigit(ch))
                {
                    throw new ArgumentException("non-number");
                }
            }

            int number = int.Parse(input);

            if (number <= start || number >= end)
            {
                throw new ArgumentException("invalid number");
            }

            return number;
        }
    }
}
