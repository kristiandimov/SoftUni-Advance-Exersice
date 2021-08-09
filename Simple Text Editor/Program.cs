﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var builder = new StringBuilder();
            Stack<string> stackTemp = new Stack<string>();
            stackTemp.Push(builder.ToString());

            for (int i = 0; i < n; i++)
            {                
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int cmd = int.Parse(input[0]);

                switch (cmd)
                {
                    case 1:
                        builder.Append(input[1]);
                        stackTemp.Push(builder.ToString());
                        break;
                    case 2:
                        int a = int.Parse(input[1]);
                        builder.Remove(builder.Length - a,a);
                        stackTemp.Push(builder.ToString());
                        break;

                    case 3:
                        int index = int.Parse(input[1]);
                        Console.WriteLine(builder[index-1]);
                        break;
                    case 4:
                        stackTemp.Pop();
                        builder = new StringBuilder();
                        builder.Append(stackTemp.Peek());
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
