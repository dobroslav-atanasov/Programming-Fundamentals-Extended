using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    public class OddOccurrences
    {
        public static void Main()
        {
            var words = Console.ReadLine().ToLower().Split(' ').ToList();

            var result = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!result.ContainsKey(word))
                {
                    result.Add(word, 0);
                }

                result[word]++;
            }

            var list = new List<string>();

            foreach (var item in result)
            {
                if (item.Value % 2 != 0)
                {
                    list.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(", ", list));
        }
    }
}
