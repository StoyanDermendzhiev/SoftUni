using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int tankCapacity = 255;
            int litersInTank = 0;

            for (int i = 1; i <= n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (liters > tankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                tankCapacity -= liters;
                litersInTank += liters;
            }
            Console.WriteLine(litersInTank);
        }
    }
}
