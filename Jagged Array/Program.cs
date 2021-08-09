using System;
using System.Linq;

namespace Jagged_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[][] jagged = new int[size][];

            for (int i = 0; i < size; i++)
            {
                jagged[i] = ReadInput();

            }

            string command = Console.ReadLine()?.ToLower();

            while (command != "end")
            {
                string[] token = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(token[1]);
                int col = int.Parse(token[2]);
                int value = int.Parse(token[3]);

                if (row < 0 || col < 0 || row >= size || col>= jagged[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    command = Console.ReadLine()?.ToLower();
                    continue;
                }

                switch (token[0])
                {
                    case "add":
                        jagged[row][col] += value;
                        break;
                    case "subtract":
                        jagged[row][col] -= value;
                        break;
                    default:
                        break;
                }


                command = Console.ReadLine()?.ToLower();
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(string.Join(" ", jagged[i]));
            }

        }

        private static int[] ReadInput()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
