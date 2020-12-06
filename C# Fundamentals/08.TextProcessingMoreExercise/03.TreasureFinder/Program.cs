using System;
using System.Linq;

namespace _03.TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine()
                               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();
            string input = Console.ReadLine();

            while (input != "find")
            {
                int keyCount = 0;
                string result = string.Empty;

                for (int i = 0; i < input.Length; i++)
                {
                    if (keyCount == key.Length)
                    {
                        keyCount = 0;
                    }

                    result += (char)(input[i] - key[keyCount]);
                    keyCount++;
                }

                string[] message = result.Split("&");

                string treasureType = message[1];
                string coordinates = message[2].Substring(message[2].IndexOf('<') + 1, 
                                                          message[2].IndexOf('>') - message[2].IndexOf('<') - 1);

                Console.WriteLine($"Found {treasureType} at {coordinates}");

                input = Console.ReadLine();
            }
        }
    }
}
