using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace _03.RageQuit
{
    public class RageQuit
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var pattern = @"(.+?)(\d{1,2})";
            var regex = new Regex(pattern);

            var matches = regex.Matches(input);

            var sb = new StringBuilder();

            foreach (Match match in matches)
            {
                var symbols = match.Groups[1].Value.ToUpper();
                var repeat = int.Parse(match.Groups[2].Value);

                for (int i = 0; i < repeat; i++)
                {
                    sb.Append(symbols);
                }
            }

            var result = sb.ToString();

            var list = new List<char>();

            foreach (var symbol in result)
            {
                list.Add(symbol);
            }

            var count = list.Distinct().ToList();

            Console.WriteLine($"Unique symbols used: {count.Count}");
            Console.WriteLine(result);
        }
    }
}
