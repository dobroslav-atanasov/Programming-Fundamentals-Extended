namespace _04.RotateArrayOfStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RotateArrayOfStrings
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(' ').ToArray();

            var result = new string[array.Length];            

            for (int i = 0; i < array.Length - 1; i++)
            {
                result[i + 1] = array[i];
            }

            result[0] = array[array.Length - 1];
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
