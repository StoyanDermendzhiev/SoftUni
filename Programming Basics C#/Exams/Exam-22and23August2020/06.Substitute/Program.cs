using System;

namespace _06.Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit1Number1 = int.Parse(Console.ReadLine());
            int digit2Number1 = int.Parse(Console.ReadLine());
            int digit1Number2 = int.Parse(Console.ReadLine());
            int digit2Number2 = int.Parse(Console.ReadLine());

            int changesCount = 0;

            for (int k = digit1Number1; k <= 8; k++)
            {
                for (int l = 9; l >= digit2Number1; l--)
                {
                    for (int m = digit1Number2; m <= 8; m++)
                    {
                        for (int n = 9; n >= digit2Number2; n--)
                        {
                            if (k % 2 == 0 && l % 2 != 0 && m % 2 == 0 & n % 2 != 0)
                            {
                                if (k != m || l != n)
                                {
                                    Console.WriteLine($"{k}{l} - {m}{n}");
                                    changesCount++;
                                }
                                else
                                {
                                    Console.WriteLine("Cannot change the same player.");
                                }
                                if (changesCount == 6)
                                {
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
