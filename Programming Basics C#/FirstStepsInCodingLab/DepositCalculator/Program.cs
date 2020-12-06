using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double dividend = double.Parse(Console.ReadLine());
            //Calculations
            double money = deposit + months * ((deposit * dividend/100) / 12);
            //Output
            Console.WriteLine($"{money:F2}");
        }
    }
}
