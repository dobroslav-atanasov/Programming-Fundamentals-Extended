namespace _07.CountOfCapitalLettersInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountOfCapitalLettersInArray
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(' ').ToArray();

            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length == 1)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
