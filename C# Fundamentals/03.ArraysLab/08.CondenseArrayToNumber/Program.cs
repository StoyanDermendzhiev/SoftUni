using System;
using System.Linq;

namespace _08.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] condensed = new int[nums.Length - 1];
            int count = nums.Length;

            if (nums.Length == 1)
            {
                Console.WriteLine(nums[0]);
                return;
            }
            while (count > 1)
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    condensed[i] = nums[i] + nums[i + 1];
                }
                nums = condensed;
                count--;
            }
            Console.WriteLine(condensed[0]);
        }
    }
}
