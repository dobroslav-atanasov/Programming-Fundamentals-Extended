using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Largest3Numbers
{
    public class Largest3Numbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var result = numbers.OrderByDescending(x => x).Take(3).ToList();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
