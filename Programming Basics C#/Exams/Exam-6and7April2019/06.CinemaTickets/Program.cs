using System;

namespace _06.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();

            int studentCount = 0;
            int standardCount = 0;
            int kidCount = 0;
            int totalCount = 0;
            while (movieName != "Finish")
            {
                int availableSeats = int.Parse(Console.ReadLine());
                string ticketType = Console.ReadLine();
                int totalCountPerMovie = 0;
                while (ticketType != "End")
                {
                    switch (ticketType)
                    {
                        case "student":
                            studentCount++;
                            break;
                        case "standard":
                            standardCount++;
                            break;
                        case "kid":
                            kidCount++;
                            break;
                    }
                    totalCountPerMovie++;
                    if (totalCountPerMovie == availableSeats)
                    {
                        break;
                    }

                    ticketType = Console.ReadLine();
                }
                double percentFull = 1.0 * totalCountPerMovie / availableSeats * 100;
                totalCount += totalCountPerMovie;
                Console.WriteLine($"{movieName} - {percentFull:f2}% full.");

                movieName = Console.ReadLine();
            }
            double percentStudentTickets = 1.0 * studentCount / totalCount * 100;
            double percentStandardTickets = 1.0 * standardCount / totalCount * 100;
            double percentKidTickets = 1.0 * kidCount / totalCount * 100;
            
            Console.WriteLine($"Total tickets: {totalCount}");
            Console.WriteLine($"{percentStudentTickets:f2}% student tickets.");
            Console.WriteLine($"{percentStandardTickets:f2}% standard tickets.");
            Console.WriteLine($"{percentKidTickets:f2}% kids tickets.");

        }
    }
}
