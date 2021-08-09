using System;
using System.Linq;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] squareMatrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] input = ReadSplitMethod();

                for (int col = 0; col < n; col++)
                {
                    squareMatrix[row, col] = input[col];
                }

            }

            int primaryDiagonal = 0;
            int secoundaryDiaglonal = 0;

            //От упр
            for (int i = 0; i < n; i++)
            {
                primaryDiagonal += squareMatrix[i, i];
                secoundaryDiaglonal += squareMatrix[i, n - i - 1];
            }


            //Моето решение 
            //int diffrence = 0;
            //int index = 0;

            //for (int i = 0; i < n; i++)
            //{  
            //    int number = squareMatrix[i, index];
            //    primaryDiagonal += number;
            //    index++;   
            //}

            //index = 0;

            //for (int i = n - 1; i >= 0; i--)
            //{
                
            //    secoundaryDiaglonal += squareMatrix[index, i];
            //    index++;
            //}


            //diffrence = Math.Abs(primaryDiagonal - secoundaryDiaglonal);

            Console.WriteLine(Math.Abs(primaryDiagonal - secoundaryDiaglonal));

        }

        private static int[] ReadSplitMethod()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
