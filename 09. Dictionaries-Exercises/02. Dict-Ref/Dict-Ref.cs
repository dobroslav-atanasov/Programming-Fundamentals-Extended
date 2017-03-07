using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Dict_Ref
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var result = new Dictionary<string, int>();

            while (input != "end")
            {
                var tokens = input.Split();
                var name = tokens[0];
                var lastElement = tokens[tokens.Length - 1];

                var number = 0;
                if (int.TryParse(lastElement, out number))
                {
                    result[name] = number;
                }
                else
                {
                    if (result.ContainsKey(lastElement))
                    {
                        var value = result[lastElement];
                        result[name] = value;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} === {item.Value}");
            }
        }
    }
}
