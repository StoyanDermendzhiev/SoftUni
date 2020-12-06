using System;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double rent = double.Parse(Console.ReadLine());
            //Calculations
            double cake = rent * 0.2;
            double drinks = cake - cake * 0.45;
            double animator = rent / 3;
            //Output
            Console.WriteLine(rent + cake + drinks + animator);
        }
    }
}
