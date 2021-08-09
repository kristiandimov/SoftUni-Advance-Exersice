using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenLines
{
    class Program
    {
        static async Task Main(string[] args)
        {

            char[] charToReplace ={ '-',',','.','!','?'};
            int count = 0;
            using (StreamReader srt = new StreamReader("text.txt"))
            {
                using StreamWriter writter = new StreamWriter("../../../output.txt");
                while (!srt.EndOfStream)
                {
                    string line = await srt.ReadLineAsync();

                    if (line == null)
                    {
                        break;
                    }

                    if (count % 2 == 0)
                    {
                        line = ReplaceAll(charToReplace, '@', line);
                        line = Reverse(line);
                        await writter.WriteLineAsync(line);
                        Console.WriteLine(line);
                    }

                    count++;
                }

            }
        }

        private static string Reverse(string line)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string[] word = line.Split(' ').ToArray();
            for (int i = 0; i < word.Length; i++)
            {
                stringBuilder.Append(word[word.Length - i - 1]);
                stringBuilder.Append(' ');
            }

            return stringBuilder.ToString().TrimEnd();
        }

        static string ReplaceAll(char[] charToReplace, char v, string line)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < line.Length; i++)
            {
                char currSymbol = line[i];
                if (charToReplace.Contains(currSymbol))
                {
                    sb.Append("@");
                }
                else
                {
                    sb.Append(currSymbol);
                }
            }
            return sb.ToString().TrimEnd();
        }
    }
}
