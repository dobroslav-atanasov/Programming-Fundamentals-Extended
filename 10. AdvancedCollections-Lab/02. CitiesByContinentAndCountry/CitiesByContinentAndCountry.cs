using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CitiesByContinentAndCountry
{
    public class CitiesByContinentAndCountry
    {
        public static void Main()
        {
            var data = new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                var tokens = Console.ReadLine().Split(' ').ToArray();
                var continent = tokens[0];
                var country = tokens[1];
                var town = tokens[2];

                if (!data.ContainsKey(continent))
                {
                    data[continent] = new Dictionary<string, List<string>>();
                }
                if (!data[continent].ContainsKey(country))
                {
                    data[continent][country] = new List<string>();
                }

                data[continent][country].Add(town);
            }

            foreach (var continentCountry in data)
            {
                var continent = continentCountry.Key;
                var country = continentCountry.Value;

                Console.WriteLine($"{continent}:");
                foreach (var town in country)
                {
                    Console.WriteLine($"  {town.Key} -> {string.Join(", ", town.Value)}");
                }
            }
        }
    }
}
