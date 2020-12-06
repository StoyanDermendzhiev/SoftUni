using System;

namespace _04.Sequence2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int output = 1;
            while (output <= n)
            {
                Console.WriteLine(output);
                output = output * 2 + 1;
            }
        }
    }
}
