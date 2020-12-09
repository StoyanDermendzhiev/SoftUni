using System;

namespace _08.Mines
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '<')
                {
                    if (input[i + 3] == '>')
                    {
                        char firstChar = input[i + 1];
                        char secondChar = input[i + 2];

                        int minePower = Math.Abs(firstChar - secondChar);
                        int lengthToBlow = minePower * 2 + 4;
                        int startIndex = i - minePower;

                        if (startIndex < 0)
                        {
                            lengthToBlow += startIndex;
                            startIndex = 0;
                        }

                        int endIndex = startIndex + lengthToBlow;

                        if (endIndex > input.Length)
                        {
                            endIndex = input.Length;
                        }

                        for (int j = startIndex; j < endIndex; j++)
                        {
                            input = input.Remove(j, 1);
                            input = input.Insert(j, "_");
                        }

                        i = -1;
                    }
                }
            }

            Console.WriteLine(input);
        }
    }
}
