using System;
using System.Net.NetworkInformation;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int piecesLeft = width * lenght;
            while(input != "STOP")
            {
                int pieces = int.Parse(input);
                piecesLeft -= pieces;
                if (piecesLeft < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(piecesLeft)} pieces more.");
                    Environment.Exit(0);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{piecesLeft} pieces are left.");
        }
    }
}
