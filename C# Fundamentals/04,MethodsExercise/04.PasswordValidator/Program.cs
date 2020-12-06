using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();

            bool IsPassValid = ValidatePasswordLenght(pass) &&
                ValidatePasswordConsistLettersAndDigits(pass) &&
                ValidatePasswordAtLeast2Digits(pass);

            if (IsPassValid)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!ValidatePasswordLenght(pass))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }

                if (!ValidatePasswordConsistLettersAndDigits(pass))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }

                if (!ValidatePasswordAtLeast2Digits(pass))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }

        private static bool ValidatePasswordAtLeast2Digits(string pass)
        {
            int count = 0;
            for (int i = 0; i < pass.Length; i++)
            {
                char index = pass[i];

                if (char.IsDigit(index))
                {
                    count++;
                }
            }

            if (count >= 2)
            {
                return true;
            }

            return false;
        }

        private static bool ValidatePasswordConsistLettersAndDigits(string pass)
        {

            for (int i = 0; i < pass.Length; i++)
            {
                char index = pass[i];

                if (!char.IsLetterOrDigit(index))
                {
                    return false;
                }
            }
            
            return true;
        }

        private static bool ValidatePasswordLenght(string pass)
        {
            if (pass.Length >= 6 && pass.Length <= 10)
            {
                return true;
            }

            return false;
        }
    }
}
