using System;
using System.Linq;

namespace Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] jaggedMatrix = new double[rows][];

            FillingJaggedMatrix(rows, jaggedMatrix);
            AnalyzingStatements(rows, jaggedMatrix);

            while (true)
            {
                string[] cmd = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string token = cmd[0].ToUpper();

                if (token == "END")
                {
                    foreach (var item in jaggedMatrix)
                    {
                        Console.Write(string.Join(' ',item));
                        Console.WriteLine();
                    }                    
                    break;
                }

                int row = int.Parse(cmd[1]);
                int col = int.Parse(cmd[2]);
                int value = int.Parse(cmd[3]);

                if ((row >= 0 && row < jaggedMatrix.Length) 
                    && (col >= 0 && col < jaggedMatrix[row].Length))
                {
                    if (token == "ADD")
                    {
                        jaggedMatrix[row][col] += value;
                    }
                    else if (token == "SUBTRACT")
                    {
                        jaggedMatrix[row][col] -= value;

                    }
                }
                
            }



        }

        private static void AnalyzingStatements(int rows, double[][] jaggedMatrix)
        {
            for (int row = 0; row < rows - 1; row++)
            {
                if (jaggedMatrix[row].Length == jaggedMatrix[row + 1].Length)
                {
                    jaggedMatrix[row] = Multipy(jaggedMatrix[row]);
                    jaggedMatrix[row + 1] = Multipy(jaggedMatrix[row + 1]);

                }
                else if (jaggedMatrix[row].Length != jaggedMatrix[row + 1].Length)
                {
                    jaggedMatrix[row] = Divide(jaggedMatrix[row]);
                    jaggedMatrix[row + 1] = Divide(jaggedMatrix[row + 1]);
                }
            }
        }

        private static void FillingJaggedMatrix(int rows, double[][] jaggedMatrix)
        {
            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                jaggedMatrix[row] = new double[input.Length];
                
                for (int col = 0; col < input.Length; col++)
                {
                    jaggedMatrix[row][col] = input[col];
                }

            }
        }

        static double[] Multipy(double[] row) =>        
            row = row.Select(x => x * 2).ToArray();                 

        static double[] Divide(double[] row) =>  
            row = row.Select(x => x / 2).ToArray();
            
        
    }
}
