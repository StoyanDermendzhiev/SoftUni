using System;

namespace _11.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageLilly = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());
            double moneySaved = 0;
            int toyCount = 0;

            for (int i = 1; i <= ageLilly; i++)
            {
                if (i % 2 == 0)
                {
                    moneySaved = moneySaved + i * 5 - 1;
                }
                else
                {
                    toyCount += 1;
                }
            }
            moneySaved = moneySaved + toyCount * toysPrice;
            if (moneySaved >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {(moneySaved-washingMachinePrice):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(washingMachinePrice-moneySaved):f2}");
            }    
        }
    }
}
