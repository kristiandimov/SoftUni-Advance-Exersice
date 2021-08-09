using System;
using System.Linq;
namespace Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            string[][] jagged = new string[rows][];
            FillingJagged(rows, jagged);

            int collected = 0;
            int colledctedByOponent = 0;
            
            while (true)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0].ToLower() == "gong")
                {
                    break;
                }

                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                

                if (row > jagged.GetLength(0) || col > jagged.Length)
                {
                    continue;
                }

                if (command[0].ToLower() == "find")
                {
                    collected += CheckForT(jagged, row, col);
                }
                else if (command[0].ToLower() == "opponent")
                {
                    string direction = command[3];

                    colledctedByOponent += CheckForT(jagged, row, col);

                    if (direction.ToLower() == "down")
                    {
                        for (int i = 1; i <= 3; i++)
                        {
                            colledctedByOponent += CheckForT(jagged, row + i, col);
                        }
                    }else if (direction.ToLower() == "up")
                    {
                        for (int i = 1; i <= 3; i++)
                        {
                            colledctedByOponent += CheckForT(jagged, row - i, col);
                        }
                    }
                    else if (direction.ToLower() == "right")
                    {
                        for (int i = 1; i <= 3; i++)
                        {
                            colledctedByOponent += CheckForT(jagged, row, col+i);
                        }
                    }
                    else if (direction.ToLower() == "left")
                    {
                        for (int i = 1; i <= 3; i++)
                        {
                            colledctedByOponent += CheckForT(jagged, row, col-i);        
                        }
                    }
                }
            }

            for (int row = 0; row < jagged.GetLength(0); row++)
            {
                    Console.WriteLine(string.Join(" ",jagged[row]));
                
            }

            Console.WriteLine($"Collected tokens: {collected}");
            Console.WriteLine($"Opponent's tokens: {colledctedByOponent}");
        }

        private static int CheckForT(string[][] jagged, int row, int col)
        {
            int count = 0;
            if ((col >= 0 && col < jagged[row].Length) && (row >= 0 && row < jagged.GetLength(0)))
            {
                if (jagged[row][col] == "T")
                {
                    count++;
                    jagged[row][col] = "-";
                }
                
            }
            return count;
        }

        private static void FillingJagged(int rows, string[][] jagged)
        {
            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                jagged[row] = new string[input.Length];

                for (int col = 0; col < input.Length; col++)
                {
                    jagged[row][col] = input[col];
                }
            }
        }
    }
}
