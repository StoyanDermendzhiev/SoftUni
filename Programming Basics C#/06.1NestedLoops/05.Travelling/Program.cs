using System;

namespace _05.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            while (destination != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                double totalSavedMoney = 0;
                while (totalSavedMoney < budget)
                {
                    double savedMoney = double.Parse(Console.ReadLine());
                    totalSavedMoney += savedMoney;
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
