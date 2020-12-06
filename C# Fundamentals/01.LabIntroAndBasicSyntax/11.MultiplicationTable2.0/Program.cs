using System;

namespace _11.MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            int product = 0;

            for (int i = times; i <= 10; i++)
            {
                product = theInteger * i;
                Console.WriteLine($"{theInteger} X {i} = {product}");
            }
            if (times > 10)
            {
                Console.WriteLine($"{theInteger} X {times} = {theInteger * times}");
            }
        }
    }
}
