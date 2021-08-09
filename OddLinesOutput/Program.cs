using System;
using System.IO;
using System.Threading.Tasks;

namespace OddLinesOutput
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (StreamReader str = new StreamReader("input.txt"))
            {
                string line = await str.ReadLineAsync();

                
                    using (StreamWriter sw = new StreamWriter("output.txt"))
                    {
                        int count = 1;

                        while (line != null)
                        {

                            await sw.WriteLineAsync($"{count}. {line}");
                            count++;
                            line = await str.ReadLineAsync();
                        }


                    }               
            }
        }
    }
}
