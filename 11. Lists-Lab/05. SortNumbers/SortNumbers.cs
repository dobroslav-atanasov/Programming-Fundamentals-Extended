namespace _05.SortNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortNumbers
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            list.Sort();

            Console.WriteLine(string.Join(" <= ", list));
        }
    }
}
