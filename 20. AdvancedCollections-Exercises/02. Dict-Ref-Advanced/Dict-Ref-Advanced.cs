using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Dict_Ref_Advanced
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var result = new Dictionary<string, List<int>>();

            while (input != "end")
            {
                var tokens = input.Split(new char[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = tokens[0];
                int numbers = 0;

                if (int.TryParse(tokens[1], out numbers))
                {
                    if (!result.ContainsKey(name))
                    {
                        result[name] = new List<int>();
                    }

                    for (int i = 1; i < tokens.Length; i++)
                    {
                        result[name].Add(int.Parse(tokens[i]));
                    }
                }
                else
                {
                    string secondName = tokens[1];
                    if (result.ContainsKey(secondName))
                    {
                        result[name] = new List<int>(result[secondName]);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var name in result)
            {
                if (name.Value.Count > 0)
                {
                    Console.WriteLine($"{name.Key} === {string.Join(", ", name.Value)}");
                }
            }
        }
    }
}
