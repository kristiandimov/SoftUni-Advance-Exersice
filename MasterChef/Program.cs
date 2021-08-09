using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterChef
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> ingredients = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            Stack<int> freshness = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Dictionary<string, int> dishes = new Dictionary<string, int>();
            Dictionary<string, int> sorted = new Dictionary<string, int>();

            dishes.Add("Chocolate cake", 0);
            dishes.Add("Dipping sauce", 0);
            dishes.Add("Green salad", 0);            
            dishes.Add("Lobster", 0);

            while(true)
            {

                if (ingredients.Count == 0 || freshness.Count == 0)
                {
                    break;
                }

                if (ingredients.Peek() <= 0)
                {
                    ingredients.Dequeue();
                    continue;
                }

                int ingredient = ingredients.Peek();
                int freshnes = freshness.Peek();

                int dish = ingredient * freshnes;

                if (dish == 150)
                {
                    ingredients.Dequeue();
                    freshness.Pop();
                    dishes["Dipping sauce"]++;

                }
                else if (dish == 250)
                {
                    ingredients.Dequeue();
                    freshness.Pop();
                    dishes["Green salad"]++;

                }
                else if (dish == 300)
                {
                    ingredients.Dequeue();
                    freshness.Pop();
                    dishes["Chocolate cake"]++;
                }
                else if (dish == 400)
                {
                    ingredients.Dequeue();
                    freshness.Pop();
                    dishes["Lobster"]++;
                }
                else
                {
                    freshness.Pop();
                    ingredients.Enqueue((ingredients.Dequeue() + 5));
                }
                             
            }

            var sb = new StringBuilder();

            if (dishes["Dipping sauce"] > 0 && dishes["Green salad"] > 0 && dishes["Chocolate cake"] > 0 && dishes["Lobster"] > 0)
            {                
                sb.AppendLine("Applause! The judges are fascinated by your dishes!");
                if (ingredients.Count > 0)
                {
                    sb.AppendLine($"Ingredients left: {Sum(ingredients).ToString()}");
                }

                foreach (var item in dishes)
                {

                    if (item.Value > 0)
                    {
                        sb.AppendLine($" # {item.Key} --> {item.Value}");
                    }

                }
                Console.WriteLine(sb);                
            }
            else
            {             
                sb.AppendLine("You were voted off. Better luck next year.");
                
                if (ingredients.Count > 0)
                {
                    sb.AppendLine($"Ingredients left: {Sum(ingredients).ToString()}");
                }

                foreach (var item in dishes)
                {
                    if (item.Value > 0)
                    {
                        sb.AppendLine($" # {item.Key} --> {item.Value}");
                    }
                    
                }

                Console.WriteLine(sb);

            }


        }

        private static int Sum(Queue<int> ingredients)
        {
            int sum = 0;

            while (ingredients.Count != 0)
            {
                
                sum += ingredients.Dequeue();
            }
                
            

            return sum;

        }
    }
}
