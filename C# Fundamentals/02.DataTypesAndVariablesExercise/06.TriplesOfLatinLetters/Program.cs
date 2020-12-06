using System;

namespace _06.TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int firstIndex = 0; firstIndex < n; firstIndex++)
            {
                for (int secondIndex = 0; secondIndex < n; secondIndex++)
                {
                    for (int thirdIndex = 0; thirdIndex < n; thirdIndex++)
                    {
                        char firsLetter = (char)('a' + firstIndex);
                        char secondLetter = (char)('a' + secondIndex);
                        char thirdLetter = (char)('a' + thirdIndex);

                        Console.WriteLine($"{firsLetter}{secondLetter}{thirdLetter}");
                    }
                }
            }
        }
    }
}
