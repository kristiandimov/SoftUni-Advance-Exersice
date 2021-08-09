using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();
            var queue = new Queue<char>(input.ToCharArray());
            char[,] snake = new char[dimensions[0], dimensions[1]];
           

            for (int row = 0; row < dimensions[0]; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < dimensions[1]; col++)
                    {
                        char current = QueueSnake(queue);
                        snake[row, col] = current;

                    }

                }
                else
                {
                    for (int col = dimensions[1] - 1; col >= 0; col--)
                    {
                        char current = QueueSnake(queue);
                        snake[row, col] = current;

                    }

                }

            }

            Print(dimensions, snake);

        }

        private static void Print(int[] dimensions, char[,] snake)
        {
            for (int row = 0; row < dimensions[0]; row++)
            {
                for (int col = 0; col < dimensions[1]; col++)
                {
                    Console.Write(snake[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static char QueueSnake(Queue<char> queue)
        {
            char currentChar = queue.Dequeue();
            queue.Enqueue(currentChar);
            return currentChar;
        }
    }
}
