using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int lenght = int.Parse(Console.ReadLine());
            int depth = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            //Calculations
            double volume = lenght * height * depth * 0.001 * (1 - percent * 0.01);
            //Output
            Console.WriteLine(volume);
        }
    }
}
