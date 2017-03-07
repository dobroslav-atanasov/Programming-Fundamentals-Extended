namespace _03.ReverseArrayIn_Place
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < list.Count / 2; i++)
            {
                var temp = list[i];
                list[i] = list[list.Count - 1 - i];
                list[list.Count - 1 - i] = temp;
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
