using System;

namespace _08.SecretDoor_sLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int hundredsUp = int.Parse(Console.ReadLine());
            int tensUp = int.Parse(Console.ReadLine());
            int unitsUp = int.Parse(Console.ReadLine());

            for (int hundreds = 1; hundreds <= hundredsUp; hundreds++)
            {
                if (hundreds % 2 == 0)
                {
                    for (int tens = 1; tens <= tensUp; tens++)
                    {
                        if (tens == 2 || tens == 3 || tens == 5 || tens == 7)
                        {
                            for (int units = 1; units <= unitsUp; units++)
                            {
                                if (units % 2 == 0)
                                {
                                    Console.WriteLine($"{hundreds} {tens} {units}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
