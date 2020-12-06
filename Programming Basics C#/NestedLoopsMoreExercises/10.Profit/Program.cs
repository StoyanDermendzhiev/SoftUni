using System;

namespace _10.Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int coin1Number = int.Parse(Console.ReadLine());
            int coin2Number = int.Parse(Console.ReadLine());
            int banknote5Number = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int coin1 = 0; coin1 <= coin1Number; coin1++)
            {
                for (int coin2 = 0; coin2 <= coin2Number; coin2++)
                {
                    for (int banknote5 = 0; banknote5 <= banknote5Number; banknote5++)
                    {
                        if (coin1 + coin2 * 2 + banknote5 * 5 == sum)
                        {
                            Console.WriteLine($"{coin1} * 1 lv. + {coin2} * 2 lv. + {banknote5} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }
        }
    }
}
