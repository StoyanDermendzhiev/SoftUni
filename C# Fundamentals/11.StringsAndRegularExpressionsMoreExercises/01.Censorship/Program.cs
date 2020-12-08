using System;

namespace _01.Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string sentence = Console.ReadLine();

            string replacingString = string.Empty;

            foreach (char ch in word)
            {
                replacingString += '*';
            }

            sentence = sentence.Replace(word, replacingString);

            Console.WriteLine(sentence);
        }
    }
}
