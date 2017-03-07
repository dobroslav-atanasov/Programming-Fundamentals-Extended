namespace _03.SumAdjacentEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i - 1] == list[i])
                {
                    list[i - 1] += list[i];
                    list.RemoveAt(i);
                    i = i - 2;
                    if (i < 0)
                    {
                        i = 0;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
