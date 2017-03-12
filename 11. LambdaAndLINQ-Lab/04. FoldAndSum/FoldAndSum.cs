using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FoldAndSum
{
    public class FoldAndSum
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = array.Length / 4;

            var row1LeftPart = array.Take(k).ToArray();
            row1LeftPart = row1LeftPart.Reverse().ToArray();

            var row1RightPart = array.Reverse().ToArray();
            row1RightPart = row1RightPart.Take(k).ToArray();

            var upperRow = row1LeftPart.Concat(row1RightPart).ToArray();

            var lowerRow = array.Skip(k).Take(k * 2).ToArray();

            var result = new int[k * 2];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = upperRow[i] + lowerRow[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
