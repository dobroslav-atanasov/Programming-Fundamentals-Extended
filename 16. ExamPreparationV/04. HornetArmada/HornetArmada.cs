using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.HornetArmada
{
    public class HornetArmada
    {
        public static void Main()
        {
            Dictionary<string, long> legionsActivity = new Dictionary<string, long>();
            Dictionary<string, Dictionary<string, long>> legionsSoldiers = new Dictionary<string, Dictionary<string, long>>();

            int n = int.Parse(Console.ReadLine());

            string pattern = @"(\d+)\s\=\s(.+)\s\-\>\s(.+)\:(\d+)";
            Regex regex = new Regex(pattern);

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();

                Match match = regex.Match(input);

                long lastActivity = long.Parse(match.Groups[1].Value);
                string name = match.Groups[2].Value;
                string type = match.Groups[3].Value;
                long count = long.Parse(match.Groups[4].Value);

                if (!legionsActivity.ContainsKey(name))
                {
                    legionsActivity.Add(name, lastActivity);
                }

                if (lastActivity > legionsActivity[name])
                {
                    legionsActivity[name] = lastActivity;
                }

                if (!legionsSoldiers.ContainsKey(name))
                {
                    legionsSoldiers[name] = new Dictionary<string, long>();
                }
                if (!legionsSoldiers[name].ContainsKey(type))
                {
                    legionsSoldiers[name][type] = 0;
                }

                legionsSoldiers[name][type] += count;
            }

            string[] commandsParts = Console.ReadLine().Split('\\');

            if (commandsParts.Length > 1)
            {
                long activity = long.Parse(commandsParts[0]);
                string command = commandsParts[1];

                foreach (var legion in legionsSoldiers.Where(x => x.Value.ContainsKey(command)).OrderByDescending(x => x.Value[command]))
                {
                    if (legionsActivity[legion.Key] < activity)
                    {
                        Console.WriteLine($"{legion.Key} -> {legionsSoldiers[legion.Key][command]}");
                    }
                }
            }
            else
            {
                string command = commandsParts[0];

                foreach (var legion in legionsActivity.OrderByDescending(x => x.Value))
                {
                    if (legionsSoldiers[legion.Key].ContainsKey(command))
                    {
                        Console.WriteLine($"{legion.Value} : {legion.Key}");
                    }
                }
            }
        }
    }
}