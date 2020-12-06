using System;

namespace _01.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            int input3 = int.Parse(Console.ReadLine());

            if (input1 >= input2 && input1 >= input3)
            {
                Console.WriteLine(input1);
                if (input2 >= input3)
                {
                    Console.WriteLine(input2);
                    Console.WriteLine(input3);
                }
                else
                {
                    Console.WriteLine(input3);
                    Console.WriteLine(input2);
                }
            }
            else if (input2 >= input1 && input2 >= input3)
            {
                Console.WriteLine(input2);
                if (input1 >= input3)
                {
                    Console.WriteLine(input1);
                    Console.WriteLine(input3);
                }
                else
                {
                    Console.WriteLine(input3);
                    Console.WriteLine(input1);
                }
            }
            else if (input3 >= input2 && input3 >= input1)
            {
                Console.WriteLine(input3);
                if (input2 >= input1)
                {
                    Console.WriteLine(input2);
                    Console.WriteLine(input1);
                }
                else
                {
                    Console.WriteLine(input1);
                    Console.WriteLine(input2);
                }
            }
        }
    }
}
