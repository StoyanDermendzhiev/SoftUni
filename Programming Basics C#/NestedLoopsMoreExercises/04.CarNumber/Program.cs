using System;

namespace _04.CarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int startInterval = int.Parse(Console.ReadLine());
            int endInterval = int.Parse(Console.ReadLine());

            for (int symbol1 = startInterval; symbol1 <= endInterval; symbol1++)
            {
                for (int symbol2 = startInterval; symbol2 <= endInterval; symbol2++)
                {
                    for (int symbol3 = startInterval; symbol3 <= endInterval; symbol3++)
                    {
                        if ((symbol2 + symbol3) % 2 == 0)
                        {
                            for (int symbol4 = startInterval; symbol4 <= endInterval; symbol4++)
                            {
                                if (symbol1 > symbol4)
                                {
                                    if (symbol1 % 2 == 0)
                                    {
                                        if (symbol4 % 2 != 0)
                                        {
                                            Console.Write($"{symbol1}{symbol2}{symbol3}{symbol4} ");
                                        }
                                    }
                                    else
                                    {
                                        if (symbol4 % 2 == 0)
                                        {
                                            Console.Write($"{symbol1}{symbol2}{symbol3}{symbol4} ");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
