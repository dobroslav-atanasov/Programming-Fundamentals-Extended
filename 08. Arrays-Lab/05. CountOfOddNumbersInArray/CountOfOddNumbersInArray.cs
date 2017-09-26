namespace _05.CountOfOddNumbersInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountOfOddNumbersInArray
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
