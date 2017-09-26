namespace _07.LargestNElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LargestNElements
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            list.Sort();
            list.Reverse();

            var result = list.Take(n);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
