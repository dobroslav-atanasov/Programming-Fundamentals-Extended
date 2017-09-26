using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ExamShopping
{
    public class ExamShopping
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var products = new Dictionary<string, int>();

            while (input != "shopping time")
            {
                var tokens = input.Split();
                var product = tokens[1];
                var quantity = int.Parse(tokens[2]);

                if (!products.ContainsKey(product))
                {
                    products[product] = 0;
                }

                products[product] += quantity;

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "exam time")
            {
                var tokens = input.Split();
                var product = tokens[1];
                var quantity = int.Parse(tokens[2]);

                if (!products.ContainsKey(product))
                {
                    Console.WriteLine($"{product} doesn't exist");
                }
                else
                {
                    if (products[product] == 0)
                    {
                        Console.WriteLine($"{product} out of stock");
                    }
                    else
                    {
                        products[product] -= quantity;
                        if (products[product] < 0)
                        {
                            products[product] = 0;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var item in products)
            {
                if (item.Value > 0)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
        }
    }
}
