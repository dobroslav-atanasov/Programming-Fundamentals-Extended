namespace _07.CountNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountNumbers
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var count = new int[list.Max() + 1];

            foreach (var num in list)
            {
                count[num]++;
            }

            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > 0)
                {
                    Console.WriteLine($"{i} -> {count[i]}");
                }
            }
        }
    }
}
