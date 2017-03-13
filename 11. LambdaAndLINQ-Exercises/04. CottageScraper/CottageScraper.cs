using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.CottageScraper
{
    public class CottageScraper
    {
        public static void Main()
        {
            var treeTypesLength = new Dictionary<string, List<int>>();
            var input = Console.ReadLine();

            while (input != "chop chop")
            {
                var tokens = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var tree = tokens[0];
                var length = int.Parse(tokens[1]);

                if (!treeTypesLength.ContainsKey(tree))
                {
                    treeTypesLength[tree] = new List<int>();
                }

                treeTypesLength[tree].Add(length);

                input = Console.ReadLine();
            }

            var typesTree = Console.ReadLine();
            var minLength = int.Parse(Console.ReadLine());
            
            var totalMeter = 0;
            var count = 0;
            foreach (var type in treeTypesLength.Values)
            {
                totalMeter += type.Sum();
                count += type.Count();
            }
            var pricePerMeter = Math.Round((totalMeter / (double)count), 2);
            
            var tallerThanMinLength = new List<int>();
            foreach (var type in treeTypesLength)
            {
                if (type.Key == typesTree)
                {
                    tallerThanMinLength = type.Value
                        .Where(x => x >= minLength)
                        .ToList();
                }
            }
            var usedLogsPrice = Math.Round(tallerThanMinLength.Sum() * pricePerMeter, 2);

            var unUsedLogs = new List<int>();
            foreach (var type in treeTypesLength)
            {
                if (type.Key != typesTree)
                {
                    foreach (var item in type.Value)
                    {
                        unUsedLogs.Add(item);
                    }
                }
                else
                {
                    foreach (var item in type.Value)
                    {
                        if (item < minLength)
                        {
                            unUsedLogs.Add(item);
                        }
                    }
                }
            }
            var unUsedLogsPrice = Math.Round(unUsedLogs.Sum() * pricePerMeter * 0.25, 2);

            Console.WriteLine($"Price per meter: ${pricePerMeter:F2}");
            Console.WriteLine($"Used logs price: ${usedLogsPrice:F2}");
            Console.WriteLine($"Unused logs price: ${unUsedLogsPrice:F2}");
            Console.WriteLine($"CottageScraper subtotal: ${(usedLogsPrice + unUsedLogsPrice):F2}");
        }
    }
}
