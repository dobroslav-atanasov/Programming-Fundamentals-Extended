using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LINQuistics
{
    public class LINQuistics
    {
        public static void Main()
        {
            var linq = new Dictionary<string, HashSet<string>>();
            var input = Console.ReadLine();

            while (input != "exit")
            {
                var tokens = input.Split(new char[] { '.', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                var collection = tokens[0];
                int number = 0;

                if (tokens.Count() > 1)
                {
                    if (!linq.ContainsKey(collection))
                    {
                        linq[collection] = new HashSet<string>();
                    }
                    for (int i = 1; i < tokens.Length; i++)
                    {
                        linq[collection].Add(tokens[i]);
                    }
                }
                else if (linq.ContainsKey(collection))
                {
                    var resultCollection = linq[collection]
                        .OrderByDescending(x => x.Length)
                        .ThenByDescending(x => x.Distinct().Count())
                        .ToList();
                    foreach (var item in resultCollection)
                    {
                        Console.WriteLine($"* {item}");
                    }
                }
                else if (int.TryParse(collection, out number) && linq.Count > 0)
                {
                    var resultNumber = linq
                        .Values
                        .OrderByDescending(x => x.Count)
                        .First()
                        .OrderBy(x => x.Length)
                        .Take(number)
                        .ToList();
                    foreach (var item in resultNumber)
                    {
                        Console.WriteLine($"* {item}");
                    }
                }

                input = Console.ReadLine();
            }

            var newInput = Console.ReadLine().Split(' ').ToArray();
            var method = newInput[0];
            var selection = newInput[1];

            var result = linq
                .Where(x => x.Value.Contains(method))
                .OrderByDescending(x => x.Value.Count)
                .ThenByDescending(x => x.Value.Min(y => y.Length))
                .ToDictionary(x => x.Key, x => x.Value);

            if (selection == "all")
            {
                foreach (var collection in result)
                {
                    Console.WriteLine($"{collection.Key}");
                    foreach (var item in result[collection.Key].OrderByDescending(x => x.Count()))
                    {
                        Console.WriteLine($"* {item}");
                    }
                }
            }
            else if (selection == "collection")
            {
                foreach (var item in result.Keys)
                {
                    Console.WriteLine($"{item}");
                }
            }
        }
    }
}
