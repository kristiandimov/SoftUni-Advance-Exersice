using System;
using System.Linq;

namespace Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            //int[,] textMatrix = new int[dimensions[0], dimensions[1]];

            string[,] textMatrix = ReadMatrix(dimensions);

            string[] cmd = ReadConsoleDataString();

            while (cmd[0].ToUpper() != "END")
            {

                if (cmd[0].ToLower() == "swap" && cmd.Length == 5)
                {

                    int firstRow = int.Parse(cmd[1]);
                    int secoundRow = int.Parse(cmd[3]);
                    int firstCol = int.Parse(cmd[2]);
                    int secoundCol = int.Parse(cmd[4]);

                    if (dimensions[0] > firstRow && dimensions[0] > secoundRow && dimensions[1] > firstCol
                        && dimensions[1] > secoundCol)
                    {
                        string temp = textMatrix[firstRow, firstCol];
                        textMatrix[firstRow, firstCol] = textMatrix[secoundRow, secoundCol];
                        textMatrix[secoundRow, secoundCol] = temp;

                        for (int r = 0; r < dimensions[0]; r++)
                        {
                            for (int c = 0; c < dimensions[1]; c++)
                            {
                                Console.Write(textMatrix[r, c] + " ");
                            }
                            Console.WriteLine();
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");

                }

                cmd = ReadConsoleDataString();
            }

        }

        private static string[,] ReadMatrix(int[] dimensions)
        {
            string[,] textMatrix = new string[dimensions[0], dimensions[1]];

            for (int row = 0; row < textMatrix.GetLength(0); row++)
            {
                string[] input = ReadConsoleDataString();

                for (int col = 0; col < textMatrix.GetLength(1); col++)
                {

                    textMatrix[row, col] = input[col];
                }
            }

            return textMatrix;
        }

        static string[] ReadConsoleDataString()
        {
            return Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
        }

        static int[] ReadConsoleData()
        {
            return Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }
    }
}
