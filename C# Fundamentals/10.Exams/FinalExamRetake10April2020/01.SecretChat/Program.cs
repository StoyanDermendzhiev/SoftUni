using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string concealedMessage = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Reveal")
            {
                string[] instruction = input.Split(":|:");
                string command = instruction[0];

                if (command == "InsertSpace")
                {
                    int index = int.Parse(instruction[1]);

                    concealedMessage = concealedMessage.Insert(index, " ");
                }
                else if (command == "Reverse")
                {
                    string substring = instruction[1];

                    if (concealedMessage.Contains(substring))
                    {
                        int startIndex = concealedMessage.IndexOf(substring);

                        concealedMessage = concealedMessage.Remove(startIndex, substring.Length); ;
                        string reverseSubstring = string.Empty;

                        for (int i = substring.Length - 1; i >= 0; i--)
                        {
                            reverseSubstring += substring[i];
                        }

                        concealedMessage += reverseSubstring;
                    }
                    else
                    {
                        Console.WriteLine("error");
                        input = Console.ReadLine();
                        continue;
                    }

                }
                else if (command == "ChangeAll")
                {
                    string substring = instruction[1];
                    string replacement = instruction[2];

                    concealedMessage = concealedMessage.Replace(substring, replacement);
                }

                Console.WriteLine(concealedMessage);

                input = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {concealedMessage}");
        }
    }
}
