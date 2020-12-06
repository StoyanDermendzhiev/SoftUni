using System;

namespace _04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int totalStepsWalked = 0;
            while (input != "Going home")
            {
                int stepsWalked = int.Parse(input);
                totalStepsWalked += stepsWalked;
                if (totalStepsWalked >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{totalStepsWalked-10000} steps over the goal!");
                    Environment.Exit(0);
                }
                input = Console.ReadLine();
            }
            int goingHomeSteps = int.Parse(Console.ReadLine());
            totalStepsWalked += goingHomeSteps;
            if (totalStepsWalked < 10000)
            {
                Console.WriteLine($"{10000 - totalStepsWalked} more steps to reach goal.");
            }
            else
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{totalStepsWalked - 10000} steps over the goal!");
            }
        }
    }
}
