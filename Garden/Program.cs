using System;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine().Split();

            var isRow = int.Parse(size[0]);
            var isCol = int.Parse(size[1]);

            var garden = new int[isRow, isCol];

            for (int row = 0; row < isRow; row++)
            {

                for (int col = 0; col < isCol; col++)
                {

                    garden[row, col] = 0;

                }
            }

            while (true)
            {
                string tokens = Console.ReadLine();
                if (tokens == "Bloom Bloom Plow")
                {
                    break;
                }

                string[] info = tokens.Split();


                var row = int.Parse(info[0]);
                var col = int.Parse(info[1]);


                if (row < 0 || row > garden.GetLength(0) && col < 0 || col > garden.GetLength(1))
                {
                    Console.WriteLine($"Invalid cordinates");
                }

                for (int i = 0; i < garden.GetLength(0); i++)
                {
                    garden[row, i]++;
                }

                for (int j = 0; j < garden.GetLength(0); j++)
                {
                    garden[j, col]++;
                }

                garden[row, col]--;

            }

            for (int row = 0; row < isRow; row++)
            {

                for (int col = 0; col < isCol; col++)
                {
                    Console.Write(garden[row, col] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}