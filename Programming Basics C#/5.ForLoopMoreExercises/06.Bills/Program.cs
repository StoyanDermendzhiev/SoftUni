using System;

namespace _06.Bills
{
    class Program
    {
      
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            int water = 20;
            int internet = 15;
            double totalElectricity = 0;
            double other = 0;
            for (int i = 1; i <= months; i++)
            {
                double electricity = double.Parse(Console.ReadLine());
                totalElectricity += electricity;
                other += (water + internet + electricity) * 1.2;
            }
            water *= months;
            internet *= months;
            double average = (water + internet + totalElectricity + other) / months;
            Console.WriteLine($"Electricity: {totalElectricity:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {other:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}
