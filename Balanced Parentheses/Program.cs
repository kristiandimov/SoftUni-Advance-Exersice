using System;
using System.Collections.Generic;
using System.Linq;

namespace Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var stack = new Stack<char>();

            if (input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            foreach (var i in input)
            {
                switch (i)
                {
                    case '(':
                    case '{':
                    case '[':
                        stack.Push(i);
                        break;
                    default:
                        if ((i == ')' || i == ']' || i == '}') && stack.Count > 0)
                        {
                            if (stack.Peek() == '(' && i == ')' || stack.Peek() == '[' && i == ']' || stack.Peek() == '{' && i == '}')
                            {
                                stack.Pop();
                            }
                            else
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                }
            }
            Console.WriteLine("YES");
            

        }
    }
}
