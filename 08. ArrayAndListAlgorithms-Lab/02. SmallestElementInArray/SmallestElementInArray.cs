namespace _02.SmallestElementInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SmallestElementInArray
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var minElement = int.MaxValue;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < minElement)
                {
                    minElement = list[i];
                }
            }

            Console.WriteLine(minElement);
        }
    }
}
