using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (1 >= n && n >= 105)
            {
                return;
            }

            Stack<int> stack = new Stack<int>();


            for (int i = 0; i < n; i++)
            {
                int[] cmd = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int command = cmd[0];

                if (1 >= command && command >= 4)
                {
                    return;
                }

                switch (command)
                {
                    case 1:
                        int x = cmd[1];
                        if (1 >= x && x >= 109)
                        {
                            return;
                        }
                        stack.Push(x);
                        break;
                    case 2:
                        if (stack.Count >0)
                        {
                            stack.Pop();
                        }
                       
                        break;
                    case 3:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Max());
                        }                  
                        break;
                    case 4:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                    default:
                        break;
                }

                
            }

            if (stack.Count > 0)
            {
                Console.WriteLine(string.Join(", ",stack));
            }

        }
    }
}
