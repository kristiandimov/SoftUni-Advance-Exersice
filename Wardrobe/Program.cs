using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            FillingDictionary(n, wardrobe);

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var clothe in color.Value)
                {
                    Console.Write($"* {clothe.Key} - {clothe.Value}");

                    if (color.Key == input[0])
                    {
                        if (clothe.Key == input[1])
                        {
                            Console.Write(" (found!)");
                        }
                    }

                    Console.WriteLine();
                    
                }
            }
        }

        static Dictionary<string, Dictionary<string, int>> FillingDictionary(int n, Dictionary<string, Dictionary<string, int>> wardrobe)
        {
            for (int i = 0; i < n; i++)
            {
                string[] color = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string currColor = color[0];
                string[] clothes = color[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (!wardrobe.ContainsKey(color[0]))
                {
                    wardrobe.Add(color[0], new Dictionary<string, int>());
                }                      
                    for (int j = 0; j < clothes.Length; j++)
                    {

                        if (!wardrobe[currColor].ContainsKey(clothes[j]))
                        {
                            wardrobe[currColor].Add(clothes[j], 0);
                        }

                        wardrobe[currColor][clothes[j]]++;

                    }           
            }
            return wardrobe;

        }
    }
}
