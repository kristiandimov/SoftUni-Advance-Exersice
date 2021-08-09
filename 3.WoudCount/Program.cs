using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace WoudCount
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Dictionary<string, int> wordOccurances = new Dictionary<string, int>();

            using (StreamReader reader = new StreamReader("words.txt"))
            {
                string line = await reader.ReadLineAsync();

                while (line != null)
                {
                    string word = line.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray()[0]
                        .ToLower();

                    if (!wordOccurances.ContainsKey(word))
                    {
                        wordOccurances[word] = 0;
                    }

                    line = await reader.ReadLineAsync();

                    
                }
            }

            using (StreamWriter writer = new StreamWriter("../../../actualResult.txt"))
            {
                using (StreamReader reader = new StreamReader("text.txt"))
                {
                    string line = await reader.ReadLineAsync();

                    while (line != null)
                    {
                        string[] words = line.Split().Select(x => x.TrimStart(new char[]
                        { '-', ',', '.', '!', '?',})).Select(x => x.TrimEnd(new char[]
                        { '-', ',', '.', '!', '?',})).Select(x => x.ToLower())
                        .ToArray();
                        foreach (string word in words)
                        {
                            if (wordOccurances.ContainsKey(word))
                            {
                                wordOccurances[word]++;
                            }
                        }
                        line = await reader.ReadLineAsync();
                    }
                    //wordOccurances.OrderByDescending(x => x.Value);
                    foreach (var kvp in wordOccurances.OrderByDescending(x => x.Value))
                    {
                        await writer.WriteLineAsync($"{kvp.Key} - {kvp.Value}");
                    }
                }
            }
        }
    }
}
