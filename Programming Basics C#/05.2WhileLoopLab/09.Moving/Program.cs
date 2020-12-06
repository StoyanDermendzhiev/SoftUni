using System;
using System.Reflection.Metadata.Ecma335;

namespace _09.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int freeSpaceVolume = width * length * height;
            int packSpaceVolume = 0;
            while (input != "Done")
            {
                int packNumber = int.Parse(input);
                packSpaceVolume += packNumber;
                if (packSpaceVolume >= freeSpaceVolume)
                {
                    Console.WriteLine($"No more free space! You need {packSpaceVolume - freeSpaceVolume} Cubic meters more.");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "Done")
            {
                Console.WriteLine($"{freeSpaceVolume - packSpaceVolume} Cubic meters left.");
            }
        }
    }
}
