using System;

namespace _04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string encryptedText = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                char ch = (char)(text[i] + 3);
                encryptedText += ch;
            }

            Console.WriteLine(encryptedText);
        }
    }
}
