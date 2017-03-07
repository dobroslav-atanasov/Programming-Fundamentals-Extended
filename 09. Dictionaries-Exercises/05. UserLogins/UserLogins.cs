using System;
using System.Collections.Generic;
using System.Linq;
namespace _05.UserLogins
{
    public class UserLogins
    {
        public static void Main()
        {
            var list = new Dictionary<string, string>();
            var input = Console.ReadLine();

            while (input != "login")
            {
                var tokens = input.Split(new char[] { '-', '>', ' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string username = tokens[0];
                string password = tokens[1];

                if (!list.ContainsKey(username))
                {
                    list[username] = string.Empty;
                }

                list[username] = password;

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            int count = 0;
            while (input != "end")
            {
                var tokens = input.Split(new char[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string username = tokens[0];
                string password = tokens[1];

                if (!list.ContainsKey(username))
                {
                    Console.WriteLine($"{username}: login failed");
                    count++;
                }
                else if (list.ContainsKey(username))
                {
                    if (list[username] != password)
                    {
                        Console.WriteLine($"{username}: login failed");
                        count++;
                    }
                    else
                    {
                        Console.WriteLine($"{username}: logged in successfully");
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"unsuccessful login attempts: {count}");
        }
    }
}
