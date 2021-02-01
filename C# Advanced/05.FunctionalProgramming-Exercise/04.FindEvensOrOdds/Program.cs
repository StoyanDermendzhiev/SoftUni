using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            int startNum = nums[0];
            int endNum = nums[1];

            Predicate<int> evenOrOdd = n=> n % 2 == 0;
            List<int> result = new List<int>();

            for (int i = startNum; i <= endNum; i++)
            {
                if (command == "odd" && !evenOrOdd(i))
                {
                    result.Add(i);
                }
                else if (command == "even" && evenOrOdd(i))
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
