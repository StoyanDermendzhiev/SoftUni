using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol1 = char.Parse(Console.ReadLine());
            char symbol2 = char.Parse(Console.ReadLine());

            CharactersInRange(symbol1, symbol2);
        }

        private static void CharactersInRange(char symbol1, char symbol2)
        {
            if (symbol1 < symbol2)
            {
                for (int i = symbol1 + 1; i < symbol2; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else if (symbol1 > symbol2)
            {
                for (int i = symbol2 + 1; i < symbol1; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
        }
    }
}
