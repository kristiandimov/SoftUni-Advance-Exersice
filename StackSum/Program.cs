﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToArray();

            Stack<string> calc = new Stack<string>(input);


            while (calc.Count>1)
            {
                int a = int.Parse(calc.Pop());
                string op = calc.Pop();
                int b = int.Parse(calc.Pop());

                if (op == "+")
                {
                    
                    calc.Push((a + b).ToString());

                }
                else if (op == "-")
                {
                    calc.Push((a - b).ToString());

                }

            }

            Console.WriteLine($"Sum: {calc.Pop()}");
            








        }
    }
}
