namespace _05.SortArrayUsingInsertionSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortArrayUsingInsertionSort
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < array.Length - 1; i++)
            {
                var n = i + 1;
                while (n > 0)
                {
                    if (array[n] < array[n - 1])
                    {
                        var temp = array[n];
                        array[n] = array[n - 1];
                        array[n - 1] = temp;
                    }
                    n--;
                }
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
