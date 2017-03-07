using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.GroupContinentsCountriesAndCities
{
    public class GroupContinentsCountriesAndCities
    {
        public static void Main()
        {
            var data = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                var tokens = Console.ReadLine().Split(' ').ToArray();
                var continent = tokens[0];
                var country = tokens[1];
                var town = tokens[2];

                if (!data.ContainsKey(continent))
                {
                    data[continent] = new SortedDictionary<string, SortedSet<string>>();
                }
                if (!data[continent].ContainsKey(country))
                {
                    data[continent][country] = new SortedSet<string>();
                }

                data[continent][country].Add(town);
            }

            foreach (var item in data)
            {
                var continent = item.Key;
                var country = item.Value;
                Console.WriteLine($"{continent}:");
                foreach (var town in country)
                {
                    Console.WriteLine($"  {town.Key} -> {string.Join(", ", town.Value)}");
                }
            }
        }
    }
}
