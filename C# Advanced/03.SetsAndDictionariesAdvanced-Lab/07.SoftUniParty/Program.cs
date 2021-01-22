using System;
using System.Collections.Generic;

namespace _07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string reservationNumber = Console.ReadLine();

            HashSet<string> vips = new HashSet<string>();
            HashSet<string> regulars = new HashSet<string>();

            while (reservationNumber != "PARTY")
            {
                if (char.IsDigit(reservationNumber[0]))
                {
                    vips.Add(reservationNumber);
                }
                else
                {
                    regulars.Add(reservationNumber);
                }

                reservationNumber = Console.ReadLine();
            }

            string partyPerson = Console.ReadLine();

            while (partyPerson != "END")
            {
                if (vips.Contains(partyPerson))
                {
                    vips.Remove(partyPerson);
                }
                else if (regulars.Contains(partyPerson))
                {
                    regulars.Remove(partyPerson);
                }

                partyPerson = Console.ReadLine();
            }

            Console.WriteLine(vips.Count + regulars.Count);

            foreach (var vip in vips)
            {
                Console.WriteLine(vip);
            }

            foreach (var regular in regulars)
            {
                Console.WriteLine(regular);
            }
        }
    }
}
