using System;

namespace _05.DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int line = int.Parse(Console.ReadLine());
            string decryptedMessage = string.Empty;

            for (int i = 0; i < line; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                decryptedMessage += (char)(symbol + key);
            }
            Console.WriteLine(decryptedMessage);
        }
    }
}
