using System;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                                    .Split();
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                string indexZero = input[0];
                for (int j = 1; j < input.Length; j++)
                {
                    input[j - 1] = input[j];
                }
                input[input.Length - 1] = indexZero;
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
