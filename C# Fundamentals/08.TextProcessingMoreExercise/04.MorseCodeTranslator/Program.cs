using System;
using System.Collections.Generic;
using System.Text;

namespace _04.MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            var morseAlphabetDictionary = new Dictionary<string, char>()
                                       {
                                       {".-", 'a'},
                                       {"-...", 'b'},
                                       {"-.-.", 'c'},
                                       {"-..", 'd'},
                                       {".", 'e'},
                                       {"..-.", 'f'},
                                       {"--.", 'g'},
                                       {"....", 'h'},
                                       {"..", 'i'},
                                       {".---", 'j'},
                                       {"-.-", 'k'},
                                       {".-..", 'l'},
                                       {"--", 'm'},
                                       {"-.", 'n'},
                                       {"---", 'o'},
                                       {".--.", 'p'},
                                       {"--.-", 'q'},
                                       {".-.", 'r'},
                                       {"...", 's'},
                                       {"-", 't'},
                                       {"..-", 'u'},
                                       {"...-", 'v'},
                                       {".--", 'w'},
                                       {"-..-", 'x'},
                                       {"-.--", 'y'},
                                       {"--..", 'z'},
                                       {"|", ' '}
                                       };

            var morseMessage = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var textMessage = new StringBuilder();

            for (int i = 0; i < morseMessage.Length; i++)
            {
                textMessage.Append(morseAlphabetDictionary[morseMessage[i]]);
            }

            Console.WriteLine(textMessage.ToString().ToUpper());
        }
    }
}
