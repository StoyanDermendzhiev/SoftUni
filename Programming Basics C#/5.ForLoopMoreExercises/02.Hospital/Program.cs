using System;

namespace _02.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int untreatedPatient = 0;
            int treatedPatient = 0;
            int doctorsNumber = 7;
            for (int i = 1; i <= period; i++)
            {
                int patientNumber = int.Parse(Console.ReadLine());
                if (i % 3 == 0 && untreatedPatient > treatedPatient)
                {
                    doctorsNumber += 1;
                }
                if (patientNumber > doctorsNumber)
                {
                    untreatedPatient += patientNumber - doctorsNumber;
                    treatedPatient += doctorsNumber;
                }
                else
                {
                    treatedPatient += patientNumber;
                }
            }
            Console.WriteLine($"Treated patients: {treatedPatient}.");
            Console.WriteLine($"Untreated patients: {untreatedPatient}.");
        }
    }
}
