using System;
using System.Linq;

namespace _2X2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string[,] matrix = new string[dimentions[0], dimentions[1]];

            FillMatrix(dimentions, matrix);
            int validMatrix = 0;

            for (int row = 0; row < dimentions[0] - 1; row++)
            {
                for (int col = 0; col < dimentions[1] - 1; col++)
                {

                    string a, b, c, d = "";
                    a = matrix[row, col];
                    b = matrix[row, col + 1];
                    c = matrix[row + 1, col];
                    d = matrix[row + 1, col + 1];

                    if (a == b && a == c && a == d)
                    {
                        validMatrix++;
                    }

                }
            }

            Console.WriteLine(validMatrix);
        }

        private static void FillMatrix(int[] dimentions, string[,] matrix)
        {
            for (int row = 0; row < dimentions[0]; row++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < dimentions[1]; col++)
                {
                    matrix[row, col] = input[col];

                }
            }
        }
    }
}
