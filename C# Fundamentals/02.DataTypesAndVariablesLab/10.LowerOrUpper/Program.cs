using System;

namespace _10.LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            if ((int)symbol >= 65 && (int)symbol <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else if ((int)symbol >= 97 && (int)symbol <= 122)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
