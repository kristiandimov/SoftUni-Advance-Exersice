using System;
using System.Linq;

namespace Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = ReadInput();

            int[,] recMatrix = FillRectangularMatrix(dimensions[0],dimensions[1]);

            int maxSum = 0;
            int sum = 0;
            int tempRow = 0;
            int tempCol = 0;



            for (int row = 0; row < recMatrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < recMatrix.GetLength(1) - 2; col++)
                {
                    sum = recMatrix[row, col] + recMatrix[row, col + 1] + recMatrix[row, col + 2]
                        + recMatrix[row + 1, col] + recMatrix[row + 1, col + 1] + recMatrix[row + 1, col + 2]
                        + recMatrix[row + 2, col] + recMatrix[row + 2, col + 1] + recMatrix[row + 2, col + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        tempRow = row;
                        tempCol = col;

                    }
                    

                }
                
            }
            Console.WriteLine($"Sum = {maxSum}");

            for (int r = tempRow; r <= tempRow+2; r++)
            {
                for (int c = tempCol; c <= tempCol+2; c++)
                {
                    Console.Write($"{recMatrix[r,c]} ");
                }
                Console.WriteLine();
            }
            
        }

        static int[,] FillRectangularMatrix(int rows,int cols)
        {
            int[,] rectangularMatrix = new int[rows, cols];

            for (int row = 0; row < rectangularMatrix.GetLength(0); row++)
            {
                int[] values = ReadInput();

                for (int col = 0; col < rectangularMatrix.GetLength(1); col++)
                {
                    rectangularMatrix[row, col] = values[col];
                }
            }

            return rectangularMatrix;

        }

        static int[] ReadInput()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
