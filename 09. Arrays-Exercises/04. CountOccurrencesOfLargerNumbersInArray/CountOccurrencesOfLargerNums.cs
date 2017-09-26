namespace _04.CountOccurrencesOfLargerNumbersInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountOccurrencesOfLargerNums
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double n = double.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > n)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
