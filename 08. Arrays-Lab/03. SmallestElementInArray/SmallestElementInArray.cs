namespace _03.SmallestElementInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SmallestElementInArray
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int smallestElement = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < smallestElement)
                {
                    smallestElement = array[i];
                }
            }

            Console.WriteLine(smallestElement);
        }
    }
}
