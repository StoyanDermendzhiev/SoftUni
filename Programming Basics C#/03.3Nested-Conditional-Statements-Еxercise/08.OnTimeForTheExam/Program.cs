using System;

namespace _08.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinutes = int.Parse(Console.ReadLine());
            //Calculations
            int hours = 0;
            int minutes = 0;
            int difference = 0;
            examMinutes += examHour * 60;
            arriveMinutes += arriveHour * 60;
            if (arriveMinutes <= examMinutes)
            {
                Console.WriteLine("On time");
                if (examMinutes - arriveMinutes <= 30)
                {
                    minutes = examMinutes - arriveMinutes;
                    Console.WriteLine($"{minutes} minutes before the start");
                }
                else if (examMinutes - arriveMinutes > 30 && examMinutes - arriveMinutes < 60)
                {
                    minutes = examMinutes - arriveMinutes;
                    Console.WriteLine("Early");
                    Console.WriteLine($"{minutes} minutes before the start");
                }
                else
                {
                    hours = (examMinutes - arriveMinutes) / 60;
                    minutes = (examMinutes - arriveMinutes) % 60;
                    Console.WriteLine("Early");
                    Console.WriteLine($"{hours}:{minutes:d2} hours before the start");
                }
            }
            else
            {
                Console.WriteLine("Late");
                if (arriveMinutes - examMinutes < 60)
                {
                    minutes = arriveMinutes - examMinutes;
                    Console.WriteLine($"{minutes} minutes after the start");
                }
                else
                {
                    hours = (arriveMinutes - examMinutes) / 60;
                    minutes = (arriveMinutes - examMinutes) % 60;
                    Console.WriteLine($"{hours}:{minutes:d2} hours after the start");
                }
            }
        }
    }
}
