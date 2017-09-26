using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.LetterRepetition
{
    public class LetterRepetition
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            var charArray = text.ToCharArray();

            var result = new Dictionary<char, int>();

            foreach (var symbol in charArray)
            {
                if (!result.ContainsKey(symbol))
                {
                    result[symbol] = 0;
                }

                result[symbol]++;
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
