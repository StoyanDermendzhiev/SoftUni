using System;

namespace _01.TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Decode")
            {
                string[] instructions = input.Split("|");
                string command = instructions[0];

                if (command == "Move")
                {
                    int numberOfLetters = int.Parse(instructions[1]);

                    string substring = message.Substring(0, numberOfLetters);
                    message = message.Remove(0, numberOfLetters) + substring;
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(instructions[1]);
                    string value = instructions[2];

                    message = message.Insert(index, value);
                }
                else if (command == "ChangeAll")
                {
                    string substring = instructions[1];
                    string replacement = instructions[2];

                    message = message.Replace(substring, replacement);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
