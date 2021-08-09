using System;
using System.Collections.Generic;

namespace Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 1);
                }
                else
                {
                    numbers[number]++;
                }

              
            }

            foreach (var number in numbers)
            {
                if (number.Value % 2 == 0)
                {
                    Console.WriteLine(number.Key);
                }
            }



        }
    }
}
