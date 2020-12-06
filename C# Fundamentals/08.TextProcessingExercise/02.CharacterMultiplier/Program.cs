using System;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();
            string str1 = strings[0];
            string str2 = strings[1];

            string def = string.Empty;
            int length = str1.Length;

            if (str1.Length > str2.Length)
            {
                def = str1.Substring(str2.Length);
                length = str2.Length;
            }
            else if (str1.Length < str2.Length)
            {
                def = str2.Substring(str1.Length);
                length = str1.Length;
            }
            

            int totalSum = 0;

            for (int i = 0; i < length; i++)
            {
                totalSum += str1[i] * str2[i];
            }

            foreach (char ch in def)
            {
                totalSum += ch;
            }

            Console.WriteLine(totalSum);
        }
    }
}
