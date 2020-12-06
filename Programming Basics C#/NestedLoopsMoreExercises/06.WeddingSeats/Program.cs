using System;

namespace _06.WeddingSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int rowNumber = int.Parse(Console.ReadLine());
            int seatsNumberOddRow = int.Parse(Console.ReadLine());
            int seatsCount = 0;
            int count = 0;
            for (char sector = 'A'; sector <= lastSector; sector++)
            {
                for (int row = 1; row <= rowNumber + count; row++)
                {
                    if (count > (lastSector - 'A'))
                    {
                        break;
                    }
                    if (row % 2 != 0)
                    {
                        for (char seatsOddRow = 'a'; seatsOddRow < ('a' + seatsNumberOddRow); seatsOddRow++)
                        {
                            Console.WriteLine($"{sector}{row}{seatsOddRow}");
                            seatsCount++;
                        }
                    }
                    else
                    {
                        for (char seatsEvenRow = 'a'; seatsEvenRow < ('a' + seatsNumberOddRow + 2); seatsEvenRow++)
                        {
                            Console.WriteLine($"{sector}{row}{seatsEvenRow}");
                            seatsCount++;
                        }
                    }
                }
                count++;
            }
            Console.WriteLine(seatsCount);
        }
    }
}
