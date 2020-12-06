using System;

namespace _03.SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sumPrime = 0;
            int sumNonPrime = 0;
            while (input != "stop")
            {
                int number = int.Parse(input);
                bool isPrime = true;
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    number = 0;
                }
                else if (number == 1)
                {
                    isPrime = false;
                }
                else
                {
                    for (int i = 2; i <= number; i++)
                    {
                        if (number % i == 0 && i != number)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }
                if (isPrime)
                {
                    sumPrime += number;
                }
                else
                {
                    sumNonPrime += number;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
