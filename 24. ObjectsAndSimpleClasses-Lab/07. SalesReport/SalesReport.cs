using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SalesReport
{
    public class SalesReport
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var result = new SortedDictionary<string, decimal>();

            for (int i = 1; i <= n; i++)
            {
                var currentSaleAsString = Console.ReadLine();
                var currentSale = Sale.Parse(currentSaleAsString);

                if (!result.ContainsKey(currentSale.Town))
                {
                    result[currentSale.Town] = 0;
                }

                result[currentSale.Town] += currentSale.Price * currentSale.Quantity;
            }

            foreach (var town in result)
            {
                Console.WriteLine($"{town.Key} -> {town.Value:F2}");
            }
        }
    }
}
