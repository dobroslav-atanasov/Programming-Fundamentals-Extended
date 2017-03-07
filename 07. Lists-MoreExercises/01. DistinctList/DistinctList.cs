namespace _01.DistinctList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DistinctList
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var result = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (!result.Contains(list[i]))
                {
                    result.Add(list[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
