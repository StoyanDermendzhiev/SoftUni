using System;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double totalSum = 0;

            foreach (string item in input)
            {
                char firstLetter = item[0];
                char lastLetter = item[item.Length - 1];
                double number = double.Parse(item.Substring(1, item.Length - 2));

                int indexOfFirstLetter = firstLetter % 32;
                int indexOfLastLetter = lastLetter % 32;

                if (char.IsUpper(firstLetter))
                {
                    number /= indexOfFirstLetter;
                }
                else
                {
                    number *= indexOfFirstLetter;
                }

                if (char.IsUpper(lastLetter))
                {
                    number -= indexOfLastLetter;
                }
                else
                {
                    number += indexOfLastLetter;
                }

                totalSum += number;
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
