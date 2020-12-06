using System;

namespace _08.EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int diff = 0;
            int maxDiff = 0;
            for (int i = 0; i < n; i++)
            {
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());
                int currentSum = number1 + number2;
                if (i == 0)
                {
                    sum = currentSum;
                }
                else
                {
                    diff = Math.Abs(sum - currentSum);
                    sum = currentSum;
                    if (diff > maxDiff)
                    {
                        maxDiff = diff;
                    }
                }
            }
            if (diff == 0)
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
