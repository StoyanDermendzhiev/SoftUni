using System;

namespace _04.GiftsFromSanta
{
    class Program
    {
        static void Main(string[] args)
        {
            int addressN = int.Parse(Console.ReadLine());
            int addressM = int.Parse(Console.ReadLine());
            int addressS = int.Parse(Console.ReadLine());

            for (int address = addressM; address >= addressN; address--)
            {
                if (address % 2 == 0 && address % 3 == 0)
                {
                    if (address == addressS)
                    {
                        return;
                    }
                    Console.Write($"{address} ");
                }
            }
        }
    }
}
