using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Palindromes
{
    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split(new char[] { ' ', ',', '.', '?', '!'}, StringSplitOptions.RemoveEmptyEntries);
            var palindromes = new List<string>();
            var result = new List<string>();

            foreach (var word in text)
            {
                var first = string.Empty;
                var second = string.Empty;

                for (int i = 0; i < word.Length / 2; i++)
                {
                    first += word[i];
                }

                if (word.Length % 2 == 0)
                {
                    for (int i = word.Length - 1; i >= word.Length / 2; i--)
                    {
                        second += word[i];
                    }
                }
                else
                {
                    for (int i = word.Length - 1; i > word.Length / 2; i--)
                    {
                        second += word[i];
                    }
                }                

                if (first == second)
                {
                    palindromes.Add(word);
                }
            }

            foreach (var item in palindromes.Distinct().OrderBy(x => x))
            {
                result.Add(item);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
