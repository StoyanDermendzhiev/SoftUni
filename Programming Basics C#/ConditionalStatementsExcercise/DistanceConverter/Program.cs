using System;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string entrance = Console.ReadLine();
            string exit = Console.ReadLine();
            if (entrance == "mm" && exit == "cm")
            {
                num /= 10;
            }
            else if (entrance == "cm" && exit == "mm")
            {
                num *= 10;
            }
            else if (entrance == "m" && exit == "mm")
            {
                num *= 1000;
            }
            else if (entrance == "mm" && exit == "m")
            {
                num /= 1000;
            }
            else if (entrance == "cm" && exit == "m")
            {
                num /= 100;
            }
            else if (entrance == "m" && exit == "cm")
            {
                num *= 100;
            }
            Console.WriteLine($"{num:F3}");
        }
    }
}
