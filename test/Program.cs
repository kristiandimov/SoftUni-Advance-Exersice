using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {             

            int[,] arr = new int[2, 2]
            {
                {1,2},
                {3,4}

            };

            Console.WriteLine(arr[1,1]);
            Console.WriteLine();
        }
    }
}
