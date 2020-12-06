using System;

namespace _01.ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawKey = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Generate")
            {
                var command = input.Split(">>>");
                string currentCommand = command[0];

                if (currentCommand == "Contains")
                {
                    string substring = command[1];

                    if (rawKey.Contains(substring))
                    {
                        Console.WriteLine($"{rawKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine($"Substring not found!");
                    }
                }
                else if (currentCommand == "Flip")
                {
                    string upOrLow = command[1];
                    int startIndex = int.Parse(command[2]);
                    int endIndex = int.Parse(command[3]);

                    string toChange = rawKey.Substring(startIndex, endIndex - startIndex);
                    rawKey = rawKey.Remove(startIndex, endIndex - startIndex);

                    if (upOrLow == "Upper")
                    {
                        toChange = toChange.ToUpper();
                    }
                    else
                    {
                        toChange = toChange.ToLower();
                    }

                    rawKey = rawKey.Insert(startIndex, toChange);

                    Console.WriteLine(rawKey);
                }
                else if (currentCommand == "Slice")
                {
                    int startIntdex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    rawKey = rawKey.Remove(startIntdex, endIndex - startIntdex);

                    Console.WriteLine(rawKey);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {rawKey}");
        }
    }
}
