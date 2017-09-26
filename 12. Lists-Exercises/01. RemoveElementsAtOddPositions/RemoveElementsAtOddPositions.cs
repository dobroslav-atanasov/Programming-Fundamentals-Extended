namespace _01.RemoveElementsAtOddPositions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveElementsAtOddPositions
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split(' ').ToList();

            var result = new List<string>();

            for (int i = 1; i < list.Count; i += 2)
            {
                result.Add(list[i]);
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
