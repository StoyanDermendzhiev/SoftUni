using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArr = Console.ReadLine()
                                    .Split();
            int biggestCount = int.MinValue;
            string output = string.Empty;

            for (int i = 0; i < inputArr.Length; i++)
            {
                int count = 0;
                string outputCount = inputArr[i] + " ";
                for (int j = i+1; j < inputArr.Length; j++)
                {
                    if (inputArr[i] == inputArr[j])
                    {
                        count++;
                        outputCount += inputArr[i] + " ";
                    }
                    else
                    {
                        break;
                    }
                }
                if (biggestCount < count)
                {
                    biggestCount = count;
                    output = outputCount;
                }
            }
            Console.WriteLine(output);
        }
    }
}
