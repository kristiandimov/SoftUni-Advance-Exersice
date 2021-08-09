using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Stack_Operations
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

            Stack<int> stcNumbers = new Stack<int>();

            PushElements(stcNumbers, numbers,n);
            PopElements(stcNumbers, s);
            Checks(stcNumbers, x);

            //for (int i = 0; i < n; i++)
            //{
            //    stcNumbers.Push(numbers[i]);
            //}

            //for (int i = 0; i < s; i++)
            //{
            //    stcNumbers.Pop();
            //}

            //if (stcNumbers.Any())
            //{
            //    if (stcNumbers.Contains(x))
            //    {
            //        Console.WriteLine("true");

            //    }
            //    else
            //    {
            //        Console.WriteLine(stcNumbers.Min());
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(0);
            //}              
        }

        static Stack<int> PushElements(Stack<int> stcNumbers, int[] numbers, int command)
        {

            for (int i = 0; i < command; i++)
            {
                stcNumbers.Push(numbers[i]);
            }

            return stcNumbers;

        }

        static Stack<int> PopElements(Stack<int> stcNumbers, int command)
        {

            for (int i = 0; i < command; i++)
            {
                stcNumbers.Pop();
            }

            return stcNumbers;

        }

        static void Checks(Stack<int> stcNumbers,int command)
        {
            if (stcNumbers.Any())
            {
                if (stcNumbers.Contains(command))
                {
                    Console.WriteLine("true");

                }
                else
                {
                    Console.WriteLine(stcNumbers.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }

    }
}
