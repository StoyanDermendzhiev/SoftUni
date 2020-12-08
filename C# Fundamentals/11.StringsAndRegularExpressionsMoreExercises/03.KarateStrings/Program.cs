using System;

namespace _03.KarateStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string karateString = Console.ReadLine();

            int strength = 0;

            for (int i = 0; i < karateString.Length; i++)
            {
                if (karateString[i] == '>')
                {
                    strength += int.Parse(karateString[i + 1].ToString());
                    continue;
                }

                if (strength > 0)
                {
                    karateString = karateString.Remove(i, 1);
                    strength--;
                    i--;
                }
            }

            Console.WriteLine(karateString);
        }
    }
}
