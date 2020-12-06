using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int days = int.Parse(Console.ReadLine());
            int cooks = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());
            //Calculations
            double money = cooks * days * (cakes * 45 + waffles * 5.80 + pancakes * 3.20) * 7 / 8;
            //Output
            Console.WriteLine(money);
        }
    }
}
