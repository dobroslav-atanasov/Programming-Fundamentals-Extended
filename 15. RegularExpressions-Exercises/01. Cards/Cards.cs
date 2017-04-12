using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.Cards
{
    public class Cards
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var cards = new List<string>();

            var pattern = @"([1]?[0-9JQKA])([SHDC])";

            var regex = new Regex(pattern);

            var matches = regex.Matches(input);

            foreach (Match card in matches)
            {
                var power = 0;

                if (int.TryParse(card.Groups[1].Value, out power))
                {
                    if (power < 2 || power > 10)
                    {
                        continue;
                    }
                }

                cards.Add(card.Value);
            }

            Console.WriteLine(string.Join(", ", cards));
        }
    }
}
