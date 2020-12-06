using System;

namespace _02.FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            for (int line = 1; line <= lines; line++)
            {
                string input = Console.ReadLine();
                int rightNumberFirstDigit = 0;
                string leftNumber = string.Empty;
                int leftNumberSum = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == '-')
                    {
                        leftNumber += input[i];
                        continue;
                    }
                    if (input[i] == ' ')
                    {
                        rightNumberFirstDigit = i + 1;
                        break;
                    }
                    leftNumber += input[i];
                    leftNumberSum += int.Parse(input[i].ToString());
                }
                string rightNumber = string.Empty;
                int rightNumberSum = 0;
                for (int j = rightNumberFirstDigit; j < input.Length; j++)
                {
                    if (input[j] == '-')
                    {
                        rightNumber += input[j];
                        continue;
                    }
                    rightNumber += input[j];
                    rightNumberSum += int.Parse(input[j].ToString());
                }

                if (long.Parse(leftNumber) > long.Parse(rightNumber))
                {
                    Console.WriteLine(leftNumberSum);
                }
                else
                {
                    Console.WriteLine(rightNumberSum);
                }
            }
        }
    }
}
