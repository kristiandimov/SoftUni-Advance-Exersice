using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = input[0];
            int s = input[1];
            int x = input[2];

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queNumbers = new Queue<int>();

            EnqueueElements(queNumbers, numbers, n);
            DequeueElements(queNumbers, s);
            Checks(queNumbers, x);

            //for (int i = 0; i < n; i++)
            //{
            //    queNumbers.Enqueue(numbers[i]);
            //}

            //for (int i = 0; i < s; i++)
            //{
            //    queNumbers.Dequeue();
            //}

            //if (stcNumbers.Any())
            //{
            //    if (queNumbers.Contains(x))
            //    {
            //        Console.WriteLine("true");

            //    }
            //    else
            //    {
            //        Console.WriteLine(queNumbers.Min());
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(0);
            //}              
        }

        static Queue<int> EnqueueElements(Queue<int> queNumbers, int[] numbers, int command)
        {

            for (int i = 0; i < command; i++)
            {
                queNumbers.Enqueue(numbers[i]);
            }

            return queNumbers;

        }

        static Queue<int> DequeueElements(Queue<int> queNumbers, int command)
        {

            for (int i = 0; i < command; i++)
            {
                queNumbers.Dequeue();
            }

            return queNumbers;

        }

        static void Checks(Queue<int> queNumbers, int command)
        {
            if (queNumbers.Any())
            {
                if (queNumbers.Contains(command))
                {
                    Console.WriteLine("true");

                }
                else
                {
                    Console.WriteLine(queNumbers.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
