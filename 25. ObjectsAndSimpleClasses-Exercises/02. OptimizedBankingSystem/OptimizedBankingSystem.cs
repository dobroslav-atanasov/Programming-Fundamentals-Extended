using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OptimizedBankingSystem
{
    public class OptimizedBankingSystem
    {
        public static void Main()
        {
            var bankingSystem = new List<BankAccount>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var newBankAccount = ReadBankAccount(input);

                bankingSystem.Add(newBankAccount);

                input = Console.ReadLine();
            }

            foreach (var account in bankingSystem.OrderByDescending(x => x.Balance).ThenBy(x => x.Bank.Length))
            {
                Console.WriteLine($"{account.Name} -> {account.Balance} ({account.Bank})");
            }
        }

        public static BankAccount ReadBankAccount(string input)
        {
            var tokens = input.Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            return new BankAccount
            {
                Bank = tokens[0],
                Name = tokens[1],
                Balance = decimal.Parse(tokens[2])
            };
        }
    }
}
