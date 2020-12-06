using System;
using System.Runtime.InteropServices;

namespace _01.PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
           //Input
            int poolVolume = int.Parse(Console.ReadLine());
            int pipe1 = int.Parse(Console.ReadLine());
            int pipe2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            //Calculations
            double income = pipe1 * hours + pipe2 * hours;
            if (income<=poolVolume)
            {
                double percentVolume = income / poolVolume * 100;
                double percentPipe1 = pipe1*hours / income * 100;
                double percentPipe2 = pipe2*hours / income * 100;
                Console.WriteLine($"The pool is {percentVolume:f2}% full. Pipe 1: {percentPipe1:f2}%. Pipe 2: {percentPipe2:f2}%.");
            }
            else
            {
                double overflow = income - poolVolume;
                Console.WriteLine($"For {hours:f2} hours the pool overflows with {overflow:f2} liters.");
            }
        }
    }
}
