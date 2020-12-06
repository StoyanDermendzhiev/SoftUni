using Microsoft.VisualBasic.CompilerServices;
using System;

namespace _03.StreamOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string word = "";
            int nCount = 0;
            int oCount = 0;
            int cCount = 0;
            while (input != "End")
            {
                char letter = Char.Parse(input);
                if (letter == 'n')
                {
                    nCount++;
                    if (nCount > 1)
                    {
                        word += letter;
                    }
                }
                if (letter == 'o')
                {
                    oCount++;
                    if (oCount > 1)
                    {
                        word += letter;
                    }
                }
                if (letter == 'c')
                {
                    cCount++;
                    if (cCount > 1)
                    {
                        word += letter;
                    }
                }
                word += letter;
                if (nCount > 0 && oCount > 0 && cCount > 0)
                {
                    Console.WriteLine($"{word} "); ;
                }
                input = Console.ReadLine();
            }
        }
    }
}
