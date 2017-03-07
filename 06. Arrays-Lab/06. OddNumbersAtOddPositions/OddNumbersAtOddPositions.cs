namespace _06.OddNumbersAtOddPositions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OddNumbersAtOddPositions
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 1; i < array.Length; i += 2)
            {
                if (array[i] % 2 != 0)
                {
                    Console.WriteLine($"Index {i} -> {array[i]}");
                }
            }
        }
    }
}
