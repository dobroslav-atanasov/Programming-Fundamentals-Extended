using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _01.RegisterUsers
{
    public class RegisterUsers
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var register = new Dictionary<string, DateTime>();

            while (input != "end")
            {
                var tokens = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = tokens[0];
                var date = DateTime.ParseExact(tokens[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                if (!register.ContainsKey(name))
                {
                    register[name] = default(DateTime);
                }

                register[name] = date;

                input = Console.ReadLine();
            }

            var lastFiveUser = register
                .Reverse()
                .OrderBy(x => x.Value)
                .Take(5)
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var user in lastFiveUser)
            {
                Console.WriteLine($"{user.Key}");
            }
        }
    }
}
