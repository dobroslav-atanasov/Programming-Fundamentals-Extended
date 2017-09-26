using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OrderedBankingSystem
{
    public class OrderedBankingSystem
    {
        public static void Main()
        {
            var bankSystem = new Dictionary<string, Dictionary<string, decimal>>();
            var input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var bank = tokens[0];
                var account = tokens[1];
                var balance = decimal.Parse(tokens[2]);

                if (!bankSystem.ContainsKey(bank))
                {
                    bankSystem.Add(bank, new Dictionary<string, decimal>());
                }
                if (!bankSystem[bank].ContainsKey(account))
                {
                    bankSystem[bank][account] = 0M;
                }
                bankSystem[bank][account] += balance;

                input = Console.ReadLine();
            }

            bankSystem
                .OrderByDescending(bank => bank.Value.Sum(account => account.Value))
                .ThenByDescending(bank => bank.Value.Max(account => account.Value))
                .ToList()
                .ForEach(bank => bank.Value
                    .OrderByDescending(account => account.Value)
                    .ToList()
                    .ForEach(account => Console.WriteLine($"{account.Key} -> {account.Value} ({bank.Key})")));
        }
    }
}
