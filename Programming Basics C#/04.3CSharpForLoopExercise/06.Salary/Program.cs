using System;

namespace _06.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            int fineFacebook = 0;
            int fineInstagram = 0;
            int fineReddit = 0;
            int totalFine = 0;
            for (int i = 0; i < n; i++)
            {
                string tab = Console.ReadLine();
                switch (tab)
                {
                    case "Facebook":
                        fineFacebook += 150;
                        break;
                    case "Instagram":
                        fineInstagram += 100;
                        break;
                    case "Reddit":
                        fineReddit += 50;
                        break;
                }
                totalFine = fineFacebook + fineInstagram + fineReddit;
                if (totalFine >= salary)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (totalFine < salary)
            {
                Console.WriteLine(salary-totalFine);
            }
        }
    }
}
