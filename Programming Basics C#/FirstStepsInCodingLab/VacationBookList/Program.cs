using System;

namespace VacationBookList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int book = int.Parse(Console.ReadLine());
            double speed = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            //Calculations
            double hours = book / speed;
            double hoursPerDay = hours / days;
            //Output
            Console.WriteLine(hoursPerDay);
        }
    }
}
