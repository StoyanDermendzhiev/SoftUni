using System;

namespace _02.LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char lastSymbol = char.Parse(Console.ReadLine());
            char noSymbol = char.Parse(Console.ReadLine());
            int count = 0;
            for (char i = firstSymbol; i <= lastSymbol; i++)
            {
                if (i != noSymbol)
                {
                    for (char j = firstSymbol; j <= lastSymbol; j++)
                    {
                        if (j != noSymbol)
                        {
                            for (char k = firstSymbol; k <= lastSymbol; k++)
                            {
                                if (k != noSymbol)
                                {
                                    count++;
                                    Console.Write($"{i}{j}{k} ");
                                }
                            }
                        }
                    }

                }
            }
            Console.WriteLine(count);
        }
    }
}
