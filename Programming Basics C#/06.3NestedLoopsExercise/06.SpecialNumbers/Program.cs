using System;

namespace _06.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1111; i <= 9999; i++)
            {
                string number = i.ToString();
                int count = 0;
                for (int j = 0; j < number.Length; j++)
                {
                    int currenSymbol = int.Parse(number[j].ToString());
                    if (currenSymbol != 0 && n % currenSymbol == 0)
                    {
                        count++;
                    }
                }
                if (count == 4)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
