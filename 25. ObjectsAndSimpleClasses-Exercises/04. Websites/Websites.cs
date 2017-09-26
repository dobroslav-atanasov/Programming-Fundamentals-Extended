using System;
using System.Collections.Generic;
using System.Linq;
namespace _04.Websites
{
    public class Websites
    {
        public static void Main()
        {
            var websites = new List<Website>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var newWebsite = ReadWebsite(input);

                websites.Add(newWebsite);

                input = Console.ReadLine();
            }

            foreach (var website in websites)
            {
                if (website.Queries != null)
                {
                    Console.WriteLine($"https://www.{website.Host}.{website.Domain}/query?=[{string.Join("]&[", website.Queries)}]");
                }
                else
                {
                    Console.WriteLine($"https://www.{website.Host}.{website.Domain}");
                }
            }
        }

        public static Website ReadWebsite(string input)
        {
            var tokens = input.Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            if (tokens.Length > 2)
            {
                var queries = tokens[2].Split(',').ToArray();

                return new Website
                {
                    Host = tokens[0],
                    Domain = tokens[1],
                    Queries = queries.ToList()
                };
            }
            else
            {
                return new Website
                {
                    Host = tokens[0],
                    Domain = tokens[1]
                };
            }
        }
    }
}
