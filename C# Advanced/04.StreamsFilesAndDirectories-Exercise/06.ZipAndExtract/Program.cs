using System;
using System.IO;
using System.IO.Compression;

namespace _06.ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("../../../zipFolder");

            using (FileStream stream = new FileStream("../../../zipFile.zip", FileMode.OpenOrCreate))
            {
                using (ZipArchive zipArchive = new ZipArchive(stream, ZipArchiveMode.Update))
                {
                    ZipArchiveEntry zipArchiveEntry = zipArchive.CreateEntryFromFile("../../../copyMe.png", "copyMeEntry");
                    zipArchiveEntry.ExtractToFile("../../../zipFolder/copyMeZipped.png", true);
                }
            }
        }
    }
}
