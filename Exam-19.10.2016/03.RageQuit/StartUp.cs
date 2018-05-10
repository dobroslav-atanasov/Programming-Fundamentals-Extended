namespace RageQuit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"(.+?)(\d{1,2})";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            StringBuilder sb = new StringBuilder();

            foreach (Match match in matches)
            {
                var symbols = match.Groups[1].Value.ToUpper();
                var repeat = int.Parse(match.Groups[2].Value);

                for (var i = 0; i < repeat; i++)
                    sb.Append(symbols);
            }

            string result = sb.ToString();
            List<char> list = new List<char>();

            foreach (char symbol in result)
            {
                list.Add(symbol);
            }

            List<char> count = list.Distinct().ToList();

            Console.WriteLine($"Unique symbols used: {count.Count}");
            Console.WriteLine(result);
        }
    }
}