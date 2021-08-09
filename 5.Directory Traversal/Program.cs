using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<FileInfo>> filesExtension = new Dictionary<string, List<FileInfo>>();

            string path = Console.ReadLine();

            string[] files = Directory.GetFiles(path);

            foreach (string file in files)
            {
                FileInfo info = new FileInfo(file);
                string extension = info.Extension;
                if (!filesExtension.ContainsKey(extension))
                {
                    filesExtension[extension] = new List<FileInfo>();
                }
                filesExtension[extension].Add(info);


            }

            using (StreamWriter writter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/report.txt"))
            {
                foreach (var kvp in filesExtension.OrderByDescending(x => x.Value.Count).ThenBy(x =>x.Key))
                {
                    writter.WriteLine(kvp.Key);
                    foreach (var fileInfo in kvp.Value.OrderBy(x => Math.Ceiling((double)x.Length / 1024)))
                    {
                        writter.WriteLine($"--{fileInfo.Name} - {Math.Ceiling((double)fileInfo.Length / 1024)}kb");
                    }
                }
            }



        }
    }
}
