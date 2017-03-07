namespace _02.ArrayElementsEqualToTheirIndex
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayElementsEqualToTheirIndex
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == i)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
