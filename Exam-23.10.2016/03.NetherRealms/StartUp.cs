namespace NetherRealms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var demons = new Dictionary<string, List<double>>();

            var input = Console.ReadLine();

            var tokens = input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var token in tokens)
            {
                var healthSymbol = token.Where(x => !char.IsDigit(x) && x != '+' && x != '-' && x != '*' && x != '/' && x != '.');

                var health = 0;

                foreach (var symbol in healthSymbol)
                {
                    health += (int)symbol;
                }

                var pattern = @"-?\d+\.?\d*";
                var regex = new Regex(pattern);

                var matches = regex.Matches(token);

                var damage = 0.0;

                foreach (Match match in matches)
                {
                    damage += double.Parse(match.Groups[0].Value);
                }

                var modifiers = token.Where(x => x == '*' || x == '/');

                foreach (var modifier in modifiers)
                {
                    if (modifier == '*')
                    {
                        damage *= 2;
                    }
                    else if (modifier == '/')
                    {
                        damage /= 2;
                    }
                }

                if (!demons.ContainsKey(token))
                {
                    demons[token] = new List<double>();
                }

                demons[token].Add(health);
                demons[token].Add(damage);
            }

            foreach (var demon in demons.OrderBy(x => x.Key))
            {
                var healthDamage = demon.Value;
                Console.WriteLine($"{demon.Key} - {healthDamage[0]} health, {healthDamage[1]:F2} damage");
            }
        }
    }
}
