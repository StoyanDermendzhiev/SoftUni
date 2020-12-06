using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            var userName = Console.ReadLine();
            var pass = Console.ReadLine();
            var reverseUserName = "";
            int count = 0;

            for (int i = userName.Length - 1; i >= 0; i--)
            {
                reverseUserName += userName[i];
            }
            while (reverseUserName != pass)
            {
                count++;
                if (count > 3)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                pass = Console.ReadLine();
            }
            Console.WriteLine($"User {userName} logged in.");
        }
    }
}

