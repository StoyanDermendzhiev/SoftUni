using System;
using System.Linq;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLine = Console.ReadLine().TrimStart('0');
            int secondLine = int.Parse(Console.ReadLine());

            if (secondLine == 0)
            {
                Console.WriteLine(secondLine);
                return;
            }
            
            
            string result = string.Empty;
            int remainder = 0;

            for (int i = firstLine.Length - 1; i >= 0; i--)
            {
                int currentMultiply = secondLine * int.Parse((firstLine[i]).ToString()) + remainder;
                string currentMultiplyString = currentMultiply.ToString();

                if (currentMultiplyString.Length > 1)
                {
                    result += currentMultiplyString[1];
                    remainder = int.Parse(currentMultiplyString[0].ToString());
                }
                else
                {
                    result += currentMultiplyString;
                    remainder = 0;
                }
            }

            if (remainder != 0)
            {
                result = result + remainder.ToString();
            }

            string finalResult = new string(result.Reverse().ToArray());

            Console.WriteLine(finalResult);
        }
    }
}
