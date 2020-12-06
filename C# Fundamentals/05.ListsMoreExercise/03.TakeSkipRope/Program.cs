using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                                         .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                         .Select(int.Parse)
                                         .ToList();
            List<int> secondList = Console.ReadLine()
                                          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .Select(int.Parse)
                                          .ToList();

            int lowerCount = 0;
            bool firstListIsLonger = true;
            if (firstList.Count > secondList.Count)
            {
                lowerCount = secondList.Count;
            }
            else
            {
                lowerCount = firstList.Count;
                firstListIsLonger = false;
            }

            secondList.Reverse();
            List<int> resultList = new List<int>(lowerCount);
            
            for (int i = 0; i < lowerCount; i++)
            {
                resultList.Add(firstList[i]);
                resultList.Add(secondList[i]);
            }

            int value1 = 0;
            int value2 = 0;
            if (firstListIsLonger)
            {
                value1 = firstList[lowerCount];
                value2 = firstList[lowerCount + 1];
            }
            else
            {
                value1 = secondList[lowerCount];
                value2 = secondList[lowerCount + 1];
            }

            int minValue = 0;
            int maxValue = 0;

            if (value1 <= value2)
            {
                minValue = value1;
                maxValue = value2;
            }
            else
            {
                minValue = value2;
                maxValue = value1;
            }

            for (int i = 0; i < resultList.Count; i++)
            {
                if (resultList[i] <= minValue || resultList[i] >= maxValue)
                {
                    resultList.Remove(resultList[i]);
                    i = -1;
                }
            }

            resultList.Sort();

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
