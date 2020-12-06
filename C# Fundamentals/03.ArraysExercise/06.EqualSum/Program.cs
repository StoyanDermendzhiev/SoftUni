using System;
using System.Linq;

namespace _06.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();
            bool isFound = false;

            for (int i = 0; i < inputArr.Length; i++)
            {
                int rightSum = 0;
                
                for (int right = i + 1; right < inputArr.Length; right++)
                {
                    rightSum += inputArr[right];
                }
                
                int leftSum = 0;
                
                for (int left = i - 1; left >= 0; left--)
                {
                    leftSum += inputArr[left];
                }
                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
