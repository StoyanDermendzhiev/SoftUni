using System;
using System.Threading;

namespace _12.TheSongOfTheWheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlNumber = int.Parse(Console.ReadLine());
            int count = 0;
            string password = "";
            bool passwordYes = false;
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (a * b + c * d == controlNumber && a < b && c > d)
                            {
                                Console.Write($"{a}{b}{c}{d} ");
                                count++;
                                if (count == 4)
                                {
                                    password = a.ToString() + b.ToString() + c.ToString() + d.ToString();
                                    passwordYes = true;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            if (passwordYes)
            {
                Console.WriteLine($"Password: {password}");
            }
            else
            {
                Console.WriteLine("No!");
            }

            
        }
    }
}
