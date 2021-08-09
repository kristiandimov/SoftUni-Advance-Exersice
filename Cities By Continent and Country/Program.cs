using System;
using System.Collections.Generic;

namespace Cities_By_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continents =
                new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] countries = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string continent = countries[0];
                string country = countries[1];
                string city = countries[2];

                if (continents.ContainsKey(continent) == false)
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());
                    //continents[countries[0]] = new Dictionary<string, List<string>>(); - drug variant

                }

                if (continents[continent].ContainsKey(country) ==  false)
                {
                    continents[continent].Add(country, new List<string>());

                }

                continents[continent][country].Add(city);

            }

            foreach (var continet in continents)
            {
                Console.WriteLine($"{continet.Key}:");

                foreach (var country in continet.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ",country.Value)}");
                }
            }



        }
    }
}
