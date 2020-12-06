using System;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLine = Console.ReadLine().ToLower();
            string secondLine = Console.ReadLine();

            while (secondLine.Contains(firstLine))
            {
                int index = secondLine.IndexOf(firstLine);
                secondLine = secondLine.Remove(index, firstLine.Length);
            }

            Console.WriteLine(secondLine);
        }
    }
}
