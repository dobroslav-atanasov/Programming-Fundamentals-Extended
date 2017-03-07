namespace _05.TearListInHalf
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TearListInHalf
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var firstRow = new List<int>();
            var secondRow = new List<int>();

            for (int i = list.Count / 2; i < list.Count; i++)
            {
                firstRow.Add(list[i]);
            }
            
            for (int i = 0; i < list.Count / 2; i++)
            {
                secondRow.Add(list[i]);
            }

            var firstDigit = 0;
            var secondDigit = 0;

            var secondSplitRow = new List<int>();

            for (int i = 0; i < firstRow.Count; i++)
            {
                secondDigit = firstRow[i] % 10;
                firstDigit = firstRow[i] / 10;
                secondSplitRow.Add(firstDigit);
                secondSplitRow.Add(secondDigit);
            }

            for (int i = 0; i < secondRow.Count; i++)
            {
                secondSplitRow.Insert(3 * i + 1, secondRow[i]);
            }

            Console.WriteLine(string.Join(" ", secondSplitRow));
        }
    }
}
