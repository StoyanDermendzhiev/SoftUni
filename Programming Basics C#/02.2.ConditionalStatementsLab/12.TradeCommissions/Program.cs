﻿using System;

namespace _12.TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            //Calculations
            double commission = 0;
            if (sales >= 0 && sales <= 500)
            {
                switch (city)
                {
                    case "Sofia":
                        commission = sales * 0.05;
                        Console.WriteLine($"{commission:f2}");
                        break;
                    case "Varna":
                        commission = sales * 0.045;
                        Console.WriteLine($"{commission:f2}");
                        break;
                    case "Plovdiv":
                        commission = sales * 0.055;
                        Console.WriteLine($"{commission:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (sales > 500 && sales <= 1000)
            {
                switch (city)
                {
                    case "Sofia":
                        commission = sales * 0.07;
                        Console.WriteLine($"{commission:f2}");
                        break;
                    case "Varna":
                        commission = sales * 0.075;
                        Console.WriteLine($"{commission:f2}");
                        break;
                    case "Plovdiv":
                        commission = sales * 0.08;
                        Console.WriteLine($"{commission:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (sales > 1000 && sales <= 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        commission = sales * 0.08;
                        Console.WriteLine($"{commission:f2}");
                        break;
                    case "Varna":
                        commission = sales * 0.10;
                        Console.WriteLine($"{commission:f2}");
                        break;
                    case "Plovdiv":
                        commission = sales * 0.12;
                        Console.WriteLine($"{commission:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (sales > 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        commission = sales * 0.12;
                        Console.WriteLine($"{commission:f2}");
                        break;
                    case "Varna":
                        commission = sales * 0.13;
                        Console.WriteLine($"{commission:f2}");
                        break;
                    case "Plovdiv":
                        commission = sales * 0.145;
                        Console.WriteLine($"{commission:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
