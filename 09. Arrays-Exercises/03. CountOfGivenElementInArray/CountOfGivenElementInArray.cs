namespace _03.CountOfGivenElementInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountOfGivenElementInArray
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            var count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == n)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
