using System;

namespace _09.Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = 0;
            int hours = 0;
            for (int i = 0; i < 24*60; i++)
            {
                if (i >= 60)
                {
                    minutes = i % 60;
                    hours = i / 60;
                    Console.WriteLine($"{hours} : {minutes}");
                }
                else
                {
                    minutes = i;
                    Console.WriteLine($"{hours} : {minutes}");
                }
            }
        }
    }
}
