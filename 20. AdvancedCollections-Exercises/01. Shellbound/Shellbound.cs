using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Shellbound
{
    public class Shellbound
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var shellbound = new Dictionary<string, HashSet<long>>();

            while (input != "Aggregate")
            {
                var tokens = input.Split(' ').ToArray();
                var region = tokens[0];
                int shell = int.Parse(tokens[1]);

                if (!shellbound.ContainsKey(region))
                {
                    shellbound[region] = new HashSet<long>();
                }

                shellbound[region].Add(shell);

                input = Console.ReadLine();
            }
                        
            foreach (var item in shellbound)
            {
                long shellSum = item.Value.Sum();
                double shellCount = item.Value.Count;
                var giantShell = Math.Ceiling(shellSum - shellSum / shellCount);
                Console.WriteLine($"{item.Key} -> {string.Join(", ", item.Value)} ({giantShell})");
            }
        }
    }
}
