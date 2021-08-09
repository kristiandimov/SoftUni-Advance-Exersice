using System;
using System.IO;
using System.Threading.Tasks;

namespace CopyBinaryFile
{
    class Program
    {
        static async Task Main(string[] args)
        {
            const int BYTE_BUFFER = 4096;
            using (FileStream reader = new FileStream("copyMe.png", FileMode.Open))
            using (FileStream writter = new FileStream("../../../png", FileMode.Create))

                while (reader.CanRead)
                {
                    byte[] buffer = new byte[BYTE_BUFFER];
                    int readBytes = reader.Read(buffer, 0, buffer.Length);
                    if (readBytes == 0)
                    {
                        break;
                    }
                    writter.Write(buffer,0, readBytes);
                }


        }
    }
}
