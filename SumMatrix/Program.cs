using System;
using System.Linq;

namespace SumMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ReadLineValues();
            int sum = 0;
            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < sizes[0]; row++)
            {
                int[] arr = ReadLineValues();


                for (int col = 0; col < sizes[1]; col++)
                {
                    matrix[row, col] = arr[col];
                   
                }
                
            }

            //Console.WriteLine(sizes[0]);
            //Console.WriteLine(sizes[1]);


            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                sum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
            }

            //foreach (var item in matrix)
            //{
            //    sum += item;
            //}

            
            
        }

        private static int[] ReadLineValues()
        {
            return Console.ReadLine()
                .Split(new string[] { ", "," " },StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
