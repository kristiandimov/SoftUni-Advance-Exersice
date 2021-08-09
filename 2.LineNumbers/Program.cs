using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LineNumbers
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string[] line = await File.ReadAllLinesAsync("text.txt");

            for (int i = 0; i < line.Length; i++)
            {
                string currentLine = line[i];
                int letterCount = CountOfLetters(currentLine);
                int punctionalCount = PunctionalCount(currentLine);

                line[i] = $"Line {i + 1}: {currentLine}. ({letterCount})({punctionalCount})";
            }
            await File.WriteAllLinesAsync("../../../output.txt", line);
        }

        private static int PunctionalCount(string currentLine)
        {
            char[] punctionalMarks = { '-', ',', '.', '!', '?','\'' };
            int cout = 0;
            for (int i = 0; i < currentLine.Length; i++)
            {
                char currentChar = currentLine[i];
                if (punctionalMarks.Contains(currentChar) && currentChar != ' ')
                {
                    cout++;
                }
            }
            return cout;

        }

        private static int CountOfLetters(string currentLine)
        {
            int count = 0;
            for (int i = 0; i < currentLine.Length; i++)
            {
                char currentChar = currentLine[i];
                if (char.IsLetter(currentChar) && currentChar != ' ')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
