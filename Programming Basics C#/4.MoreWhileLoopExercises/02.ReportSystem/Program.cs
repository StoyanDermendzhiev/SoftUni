using System;
using System.Threading;

namespace _02.ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int requiredMoney = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int count = 0;
            int csCount = 0;
            int ccCount = 0;
            int csMoney = 0;
            int ccMoney = 0;
            while (input != "End")
            {
                count++;
                int productPrice = int.Parse(input);
                if (count % 2 != 0)
                {
                    if (productPrice > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        csCount++;
                        csMoney += productPrice;
                        requiredMoney -= productPrice;
                    }
                }
                else 
                {
                    if (productPrice < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        ccCount++;
                        ccMoney += productPrice;
                        requiredMoney -= productPrice;
                    }

                }
                
                if (requiredMoney <= 0)
                {
                    double averageCS = 1.0 * csMoney / csCount;
                    double averageCC = 1.0 * ccMoney / ccCount;
                    Console.WriteLine($"Average CS: {averageCS:f2}");
                    Console.WriteLine($"Average CC: {averageCC:f2}");
                    Environment.Exit(0);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Failed to collect required money for charity.");
        }
    }
}
