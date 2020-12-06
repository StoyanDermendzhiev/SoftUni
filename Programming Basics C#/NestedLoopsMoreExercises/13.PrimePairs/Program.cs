using System;

namespace _13.PrimePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPairStart = int.Parse(Console.ReadLine());
            int secondPairStart = int.Parse(Console.ReadLine());
            int diffFirstPair = int.Parse(Console.ReadLine());
            int diffSecondPair = int.Parse(Console.ReadLine());
            for (int firstPair = firstPairStart; firstPair <= firstPairStart + diffFirstPair; firstPair++)
            {
                int countFirstPair = 0;
                for (int i = 1; i <= firstPair; i++)
                {
                    if (firstPair % i == 0)
                    {
                        countFirstPair++;
                    }
                }
                for (int secondPair = secondPairStart; secondPair <= secondPairStart + diffSecondPair; secondPair++)
                {
                    int countSecondPair = 0;
                    for (int j = 1; j <= secondPair; j++)
                    {
                        if (secondPair % j == 0)
                        {
                            countSecondPair++;
                        }
                    }
                    if (countFirstPair == 2 && countSecondPair == 2)
                    {
                        Console.WriteLine($"{firstPair}{secondPair}");
                    }
                }
            }
        }
    }
}
