using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int days = 0;
            int totalSpice = 0;

            while (startingYield >= 100)
            {
                days++;
                totalSpice += startingYield - 26;
                startingYield -= 10;
            }
            if (totalSpice >= 26)
            {
                totalSpice -= 26;
            }

            Console.WriteLine(days);
            Console.WriteLine(totalSpice);
        }
    }
}
