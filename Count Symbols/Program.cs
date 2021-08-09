using System;
using System.Collections.Generic;

namespace Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> chars = new SortedDictionary<char,int>();

            for (int i = 0; i < input.Length; i++)
            {
                char[] splitted = input.ToCharArray();

                if (!chars.ContainsKey(splitted[i]))
                {
                    chars.Add(splitted[i],1);
                }
                else
                {
                    chars[splitted[i]]++;
                }

            }

            foreach (var item in chars)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
