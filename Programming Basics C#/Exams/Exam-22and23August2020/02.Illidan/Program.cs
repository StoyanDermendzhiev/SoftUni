using System;

namespace _02.Illidan
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleInGroup = int.Parse(Console.ReadLine());
            int strenghtByPerson = int.Parse(Console.ReadLine());
            int bloodOfIllidan = int.Parse(Console.ReadLine());

            int totalStrenght = peopleInGroup * strenghtByPerson;

            if (totalStrenght < bloodOfIllidan)
            {
                Console.WriteLine($"You are not prepared! You need {bloodOfIllidan - totalStrenght} more points.");
            }
            else
            {
                Console.WriteLine($"Illidan has been slain! You defeated him with {totalStrenght - bloodOfIllidan} points.");
            }
        }
    }
}
