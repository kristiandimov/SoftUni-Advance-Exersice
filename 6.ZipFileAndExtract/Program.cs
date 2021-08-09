using System;
using System.IO.Compression;

namespace ZipFileAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@"D:\Test", @"D:\Test1\TestArchive.zip");
            ZipFile.ExtractToDirectory(@"D:\Test1\TestArchive.zip", @"D:\Test1");
        }
    }
}
