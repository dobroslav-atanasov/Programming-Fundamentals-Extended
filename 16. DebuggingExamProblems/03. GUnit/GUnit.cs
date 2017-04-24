using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.GUnit
{
    public class GUnit
    {
        public static void Main()
        {
            var dict = new Dictionary<string, Dictionary<string, List<string>>>();

            var pattern = @"^([A-Z][A-Za-z0-9]+)\s\|\s([A-Z][A-Za-z0-9]+)\s\|\s([A-Z][A-Za-z0-9]+)$";
            var regex = new Regex(pattern);

            var input = Console.ReadLine();

            while (input != "It's testing time!")
            {
                var match = regex.Match(input);

                if (match.Success)
                {
                    var className = match.Groups[1].Value;
                    var methodName = match.Groups[2].Value;
                    var unitTestName = match.Groups[3].Value;

                    if (!dict.ContainsKey(className))
                    {
                        dict[className] = new Dictionary<string, List<string>>();
                    }

                    if (!dict[className].ContainsKey(methodName))
                    {
                        dict[className][methodName] = new List<string>();
                    }

                    if (!dict[className][methodName].Contains(unitTestName))
                    {
                        dict[className][methodName].Add(unitTestName);
                    }
                }

                input = Console.ReadLine();
            }

            var classSorted = dict
                .OrderByDescending(x => x.Value.Values.Sum(y => y.Count))
                .ThenBy(x => x.Value.Count)
                .ThenBy(x => x.Key, StringComparer.Ordinal)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var clas in classSorted)
            {
                Console.WriteLine($"{clas.Key}:");

                var methodSorted = clas.Value
                    .OrderByDescending(x => x.Value.Count)
                    .ThenBy(x => x.Key, StringComparer.Ordinal)
                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var method in methodSorted)
                {
                    Console.WriteLine($"##{method.Key}");

                    var unitsSorted = method.Value
                        .OrderBy(x => x.Length)
                        .ThenBy(x => x, StringComparer.Ordinal)
                        .ToList();

                    foreach (var unit in unitsSorted)
                    {
                        Console.WriteLine($"####{unit}");
                    }
                }
            }            
        }
    }
}
