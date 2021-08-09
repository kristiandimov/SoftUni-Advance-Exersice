using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbersCount
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> count = new Dictionary<double, int>();

            foreach (var number in numbers)
            {

                if (count.ContainsKey(number))
                {
                    count[number]++;
                }
                else
                {
                    count.Add(number, 1);
                }

            }


            foreach (var number in count)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }

        }
    }
}
