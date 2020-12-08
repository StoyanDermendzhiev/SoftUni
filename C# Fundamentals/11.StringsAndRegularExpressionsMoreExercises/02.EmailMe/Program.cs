using System;

namespace _02.EmailMe
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();

            int index = email.IndexOf('@');
            int sumBefore = 0;
            int sumAfter = 0;

            for (int i = 0; i < index; i++)
            {
                sumBefore += email[i];
            }

            for (int i = index + 1; i < email.Length; i++)
            {
                sumAfter += email[i];
            }

            int result = sumBefore - sumAfter;

            if (result >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}
