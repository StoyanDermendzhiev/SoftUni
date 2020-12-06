using System;

namespace _01.NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee1 = int.Parse(Console.ReadLine());
            int employee2 = int.Parse(Console.ReadLine());
            int employee3 = int.Parse(Console.ReadLine());
            int totalPeople = int.Parse(Console.ReadLine());

            int allEmployees = employee1 + employee2 + employee3;
            
            int hours = 0;

            while (totalPeople > 0)
            {
                hours++;

                if (hours % 4 == 0)
                {
                    continue;
                }
                totalPeople -= allEmployees;
            }
           
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
