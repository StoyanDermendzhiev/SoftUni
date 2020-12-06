using System;

namespace _05.Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var sms = string.Empty;
            for (int i = 1; i <= number; i++)
            {
                var input = Console.ReadLine();
                if (input == "0")
                {
                    sms += " ";
                    continue;
                }
                int numberOfDigits = input.Length;
                int mainDigit = int.Parse(input) % 10;
                int offset = (mainDigit - 2) * 3;
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset += 1;
                }
                int letterIndex = offset + numberOfDigits - 1;
                sms += Convert.ToChar(97 + letterIndex);
            }
            Console.WriteLine(sms);
        }
    }
}
