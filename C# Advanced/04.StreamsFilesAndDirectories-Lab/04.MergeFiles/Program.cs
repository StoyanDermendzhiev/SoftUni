using System;
using System.IO;

namespace _04.MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] readFirstFile = File.ReadAllLines("../../../FileOne.txt");
            string[] readSecondFile = File.ReadAllLines("../../../FileTwo.txt");
            File.WriteAllText("../../../Output.txt", "");

            for (int i = 0; i < readFirstFile.Length; i++)
            {
                File.AppendAllText("../../../output.txt", readFirstFile[i] + Environment.NewLine + 
                                                          readSecondFile[i] + Environment.NewLine);
            }
        }
    }
}
