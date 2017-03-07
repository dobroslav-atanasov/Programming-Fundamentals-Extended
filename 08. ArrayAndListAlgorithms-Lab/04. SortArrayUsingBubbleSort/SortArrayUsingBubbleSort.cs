namespace _04.SortArrayUsingBubbleSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortArrayUsingBubbleSort
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            bool swapped = false;

            do
            {
                swapped = false;

                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        var temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
