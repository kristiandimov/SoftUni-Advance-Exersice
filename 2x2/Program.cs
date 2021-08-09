using System;
using System.Linq;

namespace _2x2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = ReadLineValues();
            int[,] matrix = new int[size[0], size[1]];

            for (int row = 0; row < size[0]; row++)
            {
                int[] input = ReadLineValues();

                for (int col = 0; col < size[1]; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int maxSum = 0;
            int sum = 0;
            int rows = 0;
            int cols = 0;

            for (int row = 0; row < size[0] - 1; row++)
            {                

                for (int col = 0; col < size[1] - 1; col++)
                {
                    sum = matrix[row, col] + matrix[row, col + 1]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        rows = row;
                        cols = col;
                    }

                }
            }

            Console.WriteLine($"{matrix[rows,cols]} {matrix[rows,cols+1]}");
            Console.WriteLine($"{matrix[rows+1,cols]} {matrix[rows+1,cols+1]}");
            Console.WriteLine(maxSum);


        }

        private static int[] ReadLineValues()
        {
            return Console.ReadLine()
                .Split(new string[] { ", ", " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
