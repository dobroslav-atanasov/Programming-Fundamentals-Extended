namespace _04.FlipListSides
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FlipListSides
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            if (list.Count % 2 != 0)
            {
                for (int i = 1; i < (list.Count - 1) / 2; i++)
                {
                    var temp = list[list.Count - 1 - i];
                    list[list.Count - 1 - i] = list[i];
                    list[i] = temp;
                }
            }
            else
            {
                for (int i = 1; i <= (list.Count - 2) / 2; i++)
                {
                    var temp = list[list.Count - 1 - i];
                    list[list.Count - 1 - i] = list[i];
                    list[i] = temp;
                }
            }
                       
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
