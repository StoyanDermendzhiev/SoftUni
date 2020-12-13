using System;
using System.Text;

namespace _01.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string inputCommand = Console.ReadLine();

            var sb = new StringBuilder();

            while (inputCommand != "Finish")
            {
                string[] command = inputCommand.Split();
                string currentCommand = command[0];

                if (currentCommand == "Replace")
                {
                    char currentChar = char.Parse(command[1]);
                    char newChar = char.Parse(command[2]);

                    message = message.Replace(currentChar, newChar);

                    sb.AppendLine(message);
                }
                else if (currentCommand == "Cut")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    if (startIndex < 0 || endIndex >= message.Length)
                    {
                        sb.AppendLine("Invalid indices!");
                    }
                    else
                    {
                        int lengthToRemove = endIndex - startIndex + 1;

                        message = message.Remove(startIndex, lengthToRemove);

                        sb.AppendLine(message);
                    }
                }
                else if (currentCommand == "Make")
                {
                    if (command[1] == "Upper")
                    {
                        message = message.ToUpper();
                    }
                    else if (command[1] == "Lower")
                    {
                        message = message.ToLower();
                    }

                    sb.AppendLine(message);
                }
                else if (currentCommand == "Check")
                {
                    string checkString = command[1];

                    if (message.Contains(checkString))
                    {
                        sb.AppendLine($"Message contains {checkString}");
                    }
                    else
                    {
                        sb.AppendLine($"Message doesn't contain {checkString}");
                    }
                }
                else if (currentCommand == "Sum")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    if (startIndex < 0 || endIndex >= message.Length)
                    {
                        sb.AppendLine("Invalid indices!");
                    }
                    else
                    {
                        int length = endIndex - startIndex + 1;
                        string substring = message.Substring(startIndex, length);

                        int asciiSum = 0;

                        foreach (char ch in substring)
                        {
                            asciiSum += ch;
                        }

                        sb.AppendLine(asciiSum.ToString());
                    }
                }

                inputCommand = Console.ReadLine();
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
