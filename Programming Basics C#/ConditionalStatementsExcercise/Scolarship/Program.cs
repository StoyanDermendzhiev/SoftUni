using System;

namespace Scolarship
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double income = double.Parse(Console.ReadLine());
            double averageResult = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());
            //Calculations
            double socialScolarship = Math.Floor(minimalSalary * 0.35);
            double resultScolarship = Math.Floor(averageResult * 25);
            if (income >= minimalSalary && averageResult >= 5.5)
            {
                Console.WriteLine($"You get a scholarship for excellent results {resultScolarship} BGN");
            }   
            else if (income >= minimalSalary && averageResult < 5.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (income<minimalSalary && averageResult>=5.5 && socialScolarship<=resultScolarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {resultScolarship} BGN");
            }
            else if (income<minimalSalary && averageResult>4.5)
            {
                Console.WriteLine($"You get a Social scholarship {socialScolarship} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }   
    }
}
