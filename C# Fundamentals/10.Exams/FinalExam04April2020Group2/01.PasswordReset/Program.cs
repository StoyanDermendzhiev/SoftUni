using System;
using System.Linq;

namespace _01.PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string commandLine = Console.ReadLine();

            while (commandLine != "Done")
            {
                string[] command = commandLine.Split();
                string currendCommand = command[0];

                if (currendCommand == "TakeOdd")
                {
                    string newPassword = string.Empty;

                    for (int i = 1; i < password.Length; i += 2)
                    {
                        newPassword += password[i];
                    }

                    password = newPassword;

                    Console.WriteLine(password);
                }
                else if (currendCommand == "Cut")
                {
                    int index = int.Parse(command[1]);
                    int length = int.Parse(command[2]);

                    password = password.Remove(index, length);

                    Console.WriteLine(password);
                }
                else if (currendCommand == "Substitute")
                {
                    string substring = command[1];
                    string substitute = command[2];

                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine($"Nothing to replace!");
                    }
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
