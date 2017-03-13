using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.DefaultValues
{
    public class DefaultValues
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var dictionary = new Dictionary<string, string>();

            while (input != "end")
            {
                var tokens = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = tokens[0];
                var value = tokens[1];

                if (!dictionary.ContainsKey(name))
                {
                    dictionary[name] = string.Empty;
                }

                dictionary[name] = value;

                input = Console.ReadLine();
            }

            var defaultValue = Console.ReadLine();

            var withOutChange = dictionary
                .Where(x => x.Value != "null")
                .OrderByDescending(x => x.Value.Length)
                .ToDictionary(x => x.Key, x => x.Value);
            
            var changeValue = dictionary
                .Where(x => x.Value == "null")
                .ToDictionary(x => x.Key, x => defaultValue);

            foreach (var item in withOutChange)
            {
                Console.WriteLine($"{item.Key} <-> {item.Value}");
            }

            foreach (var item in changeValue)
            {
                Console.WriteLine($"{item.Key} <-> {item.Value}");
            }
        }
    }
}
