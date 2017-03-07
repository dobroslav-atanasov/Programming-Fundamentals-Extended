using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MixedPhones
{
    public class MixedPhones
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var result = new SortedDictionary<string, long>();

            while (input != "Over")
            {
                var tokens = input.Split(new char[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                long number = 0;
                if (long.TryParse(tokens[0], out number))
                {
                    result[tokens[1]] = number;
                }
                else
                {
                    result[tokens[0]] = long.Parse(tokens[1]);
                }

                input = Console.ReadLine();
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
