using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            var lilies = new Stack<int>(Console.ReadLine()
                                               .Split(", ")
                                               .Select(int.Parse));
            var roses = new Queue<int>(Console.ReadLine()
                                               .Split(", ")
                                               .Select(int.Parse));

            int wreathsCount = 0;
            int storedFlowers = 0;

            while (lilies.Count > 0 && roses.Count > 0)
            {
                int currLilies = lilies.Peek();
                int currRoses = roses.Peek();

                if (currLilies + currRoses == 15)
                {
                    wreathsCount++;
                    lilies.Pop();
                    roses.Dequeue();
                }
                else if (currLilies + currRoses > 15)
                {
                    lilies.Pop();
                    lilies.Push(currLilies - 2);
                }
                else
                {
                    storedFlowers += currLilies + currRoses;
                    lilies.Pop();
                    roses.Dequeue();
                }
            }

            if (storedFlowers > 0)
            {
                wreathsCount += storedFlowers / 15;
            }

            if (wreathsCount >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreathsCount} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreathsCount} wreaths more!");
            }
        }
    }
}
