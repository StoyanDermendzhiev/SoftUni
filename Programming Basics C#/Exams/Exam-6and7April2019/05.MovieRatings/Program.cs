using System;

namespace _05.MovieRatings
{
    class Program
    {
        static void Main(string[] args)
        {
            int movieNumber = int.Parse(Console.ReadLine());
            double minRating = 10.01;
            double maxRating = 0.99;
            double totalRating = 0;
            string movieWithMaxRating = "";
            string movieWithMinRating = "";

            for (int movie = 1; movie <= movieNumber; movie++)
            {
                string movieName = Console.ReadLine();
                double movieRating = double.Parse(Console.ReadLine());

                if (movieRating > maxRating)
                {
                    maxRating = movieRating;
                    movieWithMaxRating = movieName;
                }
                if (movieRating < minRating)
                {
                    minRating = movieRating;
                    movieWithMinRating = movieName;
                }
                totalRating += movieRating;
            }
            double averageRating = totalRating / movieNumber;
            Console.WriteLine($"{movieWithMaxRating} is with highest rating: {maxRating:f1}");
            Console.WriteLine($"{movieWithMinRating} is with lowest rating: {minRating:f1}");
            Console.WriteLine($"Average rating: {averageRating:f1}");

        }
    }
}
