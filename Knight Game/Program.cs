using System;

namespace Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 0 && 30 < n)
            {
                return;
            }

            char[,] table = FillingTable(n);
            int removedKnights = 0;
            while (true)
            {
                int knightRow = -1;
                int knightCol = -1;
                int knightAttack = 0;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (table[row,col] == 'K')
                        {
                            int tempAttack = CountAttacks(table, row, col);

                            if (tempAttack>knightAttack)
                            {
                                knightAttack = tempAttack;
                                knightRow = row;
                                knightCol = col;

                            }
                        }
                    }
                }
                if (knightAttack > 0)
                {
                    table[knightRow, knightCol] = '0';
                    removedKnights++;
                }
                else
                {
                    break;
                }

            }

            Console.WriteLine(removedKnights);

        }

        private static int CountAttacks(char[,] table, int row, int col)
        {
            int attacks = 0;

            if (IsInMatrix(row+1,col-2,table.GetLength(0)) && table[row+1,col-2] == 'K')
            {
                attacks++;
            }

            if (IsInMatrix(row - 1, col - 2, table.GetLength(0)) && table[row - 1, col - 2] == 'K')
            {
                attacks++;
            }

            if (IsInMatrix(row - 1, col + 2, table.GetLength(0)) && table[row - 1, col + 2] == 'K')
            {
                attacks++;
            }

            if (IsInMatrix(row + 1, col + 2, table.GetLength(0)) && table[row + 1, col + 2] == 'K')
            {
                attacks++;
            }

            if (IsInMatrix(row - 2, col - 1, table.GetLength(0)) && table[row - 2, col - 1] == 'K')
            {
                attacks++;
            }

            if (IsInMatrix(row - 2, col + 1, table.GetLength(0)) && table[row - 2, col + 1] == 'K')
            {
                attacks++;
            }

            if (IsInMatrix(row +2, col -1, table.GetLength(0)) && table[row +2, col - 1] == 'K')
            {
                attacks++;
            }

            if (IsInMatrix(row + 2, col +1, table.GetLength(0)) && table[row +2, col +1] == 'K')
            {
                attacks++;
            }

            return attacks;
            
        }

        private static bool IsInMatrix(int row,int col,int lenght)
        {
            return row >= 0 && row < lenght && col >= 0 && col < lenght;
        }

        private static char[,] FillingTable(int n)
        {
            char[,] table = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    table[row, col] = input[col];
                }
            }

            return table;

        }
    }
}
