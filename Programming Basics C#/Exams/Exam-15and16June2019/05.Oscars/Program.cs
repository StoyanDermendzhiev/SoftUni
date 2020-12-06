using System;

namespace _05.Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int judgesNumber = int.Parse(Console.ReadLine());

            for (int judge = 1; judge <= judgesNumber; judge++)
            {
                string judgeName = Console.ReadLine();
                double judgePoints = double.Parse(Console.ReadLine());

                double actorPoints = judgeName.Length * judgePoints / 2;
                academyPoints += actorPoints;

                if (academyPoints > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {academyPoints:f1}!");
                    return;
                }
            }
            Console.WriteLine($"Sorry, {actorName} you need {1250.5-academyPoints:f1} more!");
        }
    }
}
