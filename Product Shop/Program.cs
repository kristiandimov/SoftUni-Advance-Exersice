using System;
using System.Collections.Generic;

namespace Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, double>> shops = 
                new Dictionary<string, Dictionary<string, double>>();

            while (input?.ToUpper() != "REVISION" )
            {
                string[] tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                if (!shops.ContainsKey(tokens[0]))
                {
                    shops[tokens[0]] = new Dictionary<string, double>();
                }

                shops[tokens[0]].Add(tokens[1], double.Parse(tokens[2]));

                input = Console.ReadLine();
            
            }

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key} , Price: {product.Value}");
                }
            }
        }
    }
}
