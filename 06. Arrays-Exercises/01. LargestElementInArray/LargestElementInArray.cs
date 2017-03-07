namespace _01.LargestElementInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LargestElementInArray
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int largestElement = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > largestElement)
                {
                    largestElement = array[i];
                }
            }

            Console.WriteLine(largestElement);
        }
    }
}
