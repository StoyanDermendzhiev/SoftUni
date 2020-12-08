using System;

namespace _05.OnlyLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            int digitCount = 0;

            for (int i = 0; i < message.Length; i++)
            {
                if (char.IsDigit(message[i]))
                {
                    digitCount++;
                    continue;
                }
                else
                {
                    if (digitCount > 0)
                    {
                        string letter = message[i].ToString();
                        message = message.Remove(i - digitCount, digitCount);
                        message = message.Insert(i - digitCount, letter);
                        i -= digitCount + 1;
                        digitCount = 0;
                    }
                }
            }

            Console.WriteLine(message);
        }
    }
}
