namespace _06.SquareNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SquareNumbers
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            var result = new List<long>();

            for (int i = 0; i < list.Count; i++)
            {
                if (Math.Sqrt(list[i]) == (int)Math.Sqrt(list[i]))
                {
                    result.Add(list[i]);
                }
            }

            result.Sort();
            result.Reverse();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
