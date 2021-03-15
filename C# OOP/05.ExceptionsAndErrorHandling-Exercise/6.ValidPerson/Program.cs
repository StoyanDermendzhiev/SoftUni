using System;
using System.Net.Mail;

namespace _6.ValidPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pesho = new Person("Pesho", "Peshev", 24);

            try
            {
                Person noName = new Person(string.Empty, "Goshev", 31);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Person noLastName = new Person("Ivan", null, 63);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Person negativeAge = new Person("Stoyan", "Kolev", -1);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Person tooOld = new Person("Iskren", "Ivanov", 124);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Student student = new Student("Gin4o", "gin4o@abv.bg");
            }
            catch (InvalidPersonNameException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
