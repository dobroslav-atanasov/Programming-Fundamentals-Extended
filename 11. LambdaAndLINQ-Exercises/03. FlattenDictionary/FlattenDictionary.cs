using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.FlattenDictionary
{
    public class FlattenDictionary
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var dictionary = new Dictionary<string, Dictionary<string, string>>();

            while (input != "end")
            {
                var tokens = input.Split(' ').ToArray();
                if (tokens[0] != "flatten")
                {
                    var key = tokens[0];
                    var innerKey = tokens[1];
                    var innerValue = tokens[2];

                    if (!dictionary.ContainsKey(key))
                    {
                        dictionary[key] = new Dictionary<string, string>();
                    }
                    if (!dictionary[key].ContainsKey(innerKey))
                    {
                        dictionary[key][innerKey] = string.Empty;
                    }

                    dictionary[key][innerKey] = innerValue;
                }
                else
                {
                    var key = tokens[1];
                    dictionary[key] = dictionary[key]
                        .ToDictionary(x => x.Key + x.Value, x => "flatten");
                }
                input = Console.ReadLine();
            }

            var order = dictionary
                .OrderByDescending(x => x.Key.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in order)
            {
                Console.WriteLine($"{item.Key}");

                var orderInner = item.Value
                    .Where(x => x.Value != "flatten")
                    .OrderBy(x => x.Key.Length)
                    .ToDictionary(x => x.Key, x => x.Value);

                var flattenValue = item.Value
                    .Where(x => x.Value == "flatten")
                    .ToDictionary(x => x.Key, x => x.Value);

                var count = 1;
                foreach (var inner in orderInner)
                {
                    Console.WriteLine($"{count}. {inner.Key} - {inner.Value}");
                    count++;
                }
                
                foreach (var flatten in flattenValue)
                {
                    Console.WriteLine($"{count}. {flatten.Key}");
                    count++;
                }
            }
        }
    }
}
