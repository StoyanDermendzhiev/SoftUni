using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int pokeCount = 0;
            int originalPower = power;

            while (power >= distance)
            {
                power -= distance;
                pokeCount++;
                if ((double)originalPower / power == 2)
                {
                    if (power >= exhaustionFactor && exhaustionFactor != 0)
                    {
                    power /= exhaustionFactor;
                    }
                }
            }

            Console.WriteLine(power);
            Console.WriteLine(pokeCount);
        }
    }
}
