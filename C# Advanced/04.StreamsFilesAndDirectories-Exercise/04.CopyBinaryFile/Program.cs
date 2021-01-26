using System;
using System.IO;

namespace _04.CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream readStream = new FileStream("../../../copyMe.png", FileMode.Open, FileAccess.Read))
            {

                using (FileStream writeStream = new FileStream("../../../copied.png", FileMode.Create, FileAccess.Write))
                {

                    while (true)
                    {
                        byte[] buffer = new byte[4096];
                        int count = readStream.Read(buffer, 0, buffer.Length);

                        if (count == 0)
                        {
                            break;
                        }

                        writeStream.Write(buffer);
                    }
                }
            }
        }
    }
}
