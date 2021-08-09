using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] lenghts = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = lenghts[0];
            int m = lenghts[1];

            HashSet<int> setN = new HashSet<int>();
            HashSet<int> setM = new HashSet<int>();
            FillSet(setN, n);
            FillSet(setM, m);

            List<int> nums = new List<int>();
            foreach (int set in setN)
            {
                

                if (setM.Contains(set))
                {
                    nums.Add(set);
                }
                
            }

            Console.WriteLine(string.Join(" ",nums));

        }

       

        static HashSet<int> FillSet(HashSet<int> set ,int lenght)
        {
            for (int i = 0; i < lenght; i++)
            {
                set.Add(int.Parse(Console.ReadLine()));
            }

            return set;
        }
    }
}
