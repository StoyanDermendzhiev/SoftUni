using System;

namespace _10.InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int number = int.Parse(Console.ReadLine());
            //Calculations
            bool valid = number >= 100 && number <= 200 || number == 0;
                if (!valid)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
