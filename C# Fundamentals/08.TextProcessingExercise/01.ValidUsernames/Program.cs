using System;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine().Split(", ");

            foreach (string userName in userNames)
            {
                bool isValid = true;

                if (userName.Length >= 3 && userName.Length <= 16)
                {
                    foreach (char ch in userName)
                    {
                        if (!(char.IsDigit(ch) ||
                            char.IsLetter(ch) ||
                            ch == '_' ||
                            ch == '-'))
                        {
                            isValid = false;
                        }
                    }
                }
                else
                {
                    isValid = false;
                }

                if (isValid)
                {
                    Console.WriteLine(userName);
                }
            }
        }
    }
}
