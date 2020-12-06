using System;

namespace _06.Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floorNumber = int.Parse(Console.ReadLine());
            int roomNumber = int.Parse(Console.ReadLine());
            for (int f = floorNumber; f >= 1; f--)
            {
                for (int r = 0; r < roomNumber; r++)
                {
                    if (f == floorNumber)
                    {
                        Console.Write($"L{f}{r} ");
                        if (r == roomNumber - 1)
                        {
                            Console.WriteLine();
                        }
                    }
                    else if (f % 2 != 0)
                    {
                        Console.Write($"A{f}{r} ");
                        if (r == roomNumber - 1)
                        {
                            Console.WriteLine();
                        }
                    }
                    else if (f % 2 == 0 && f != floorNumber)
                    {
                        Console.Write($"O{f}{r} ");
                        if (r == roomNumber - 1)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
