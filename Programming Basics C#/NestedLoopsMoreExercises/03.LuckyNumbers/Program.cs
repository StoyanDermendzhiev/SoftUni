using System;

namespace _03.LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int symbol1 = 1; symbol1 <= 9; symbol1++)
            {
                for (int symbol2 = 1; symbol2 <= 9; symbol2++)
                {
                    if (n % (symbol1 + symbol2) == 0)
                    {
                        for (int symbol3 = 1; symbol3 <= 9; symbol3++)
                        {
                            for (int symbol4 = 1; symbol4 <= 9; symbol4++)
                            {
                                if(symbol1 + symbol2 == symbol3 + symbol4)
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
