using System;

namespace _07.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int totalTicket = 0;
            int totalStudentTicket = 0;
            int totalStandartTicket = 0;
            int totalKidTicket = 0;
            while (movieName != "Finish")
            {
                int studentCount = 0;
                int standartCount = 0;
                int kidCount = 0;
                int allTicketCount = 0;
                int freePlaces = int.Parse(Console.ReadLine());
                string ticketType = Console.ReadLine();
                while (ticketType != "End")
                {
                    switch (ticketType)
                    {
                        case "student":
                            studentCount++;
                            break;
                        case "standard":
                            standartCount++;
                            break;
                        case "kid":
                            kidCount++;
                            break;
                    }
                    allTicketCount = studentCount + standartCount + kidCount;
                    if (allTicketCount == freePlaces)
                    {
                        break;
                    }
                    ticketType = Console.ReadLine();
                }
                totalTicket += allTicketCount;
                totalStudentTicket += studentCount;
                totalStandartTicket += standartCount;
                totalKidTicket += kidCount;
                Console.WriteLine($"{movieName} - {(1.0 * allTicketCount / freePlaces * 100):f2}% full.");
                movieName = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalTicket}");
            Console.WriteLine($"{(1.0 * totalStudentTicket / totalTicket * 100):f2}% student tickets.");
            Console.WriteLine($"{(1.0 * totalStandartTicket / totalTicket * 100):f2}% standard tickets.");
            Console.WriteLine($"{(1.0 * totalKidTicket / totalTicket * 100):f2}% kids tickets.");
        }
    }
}
