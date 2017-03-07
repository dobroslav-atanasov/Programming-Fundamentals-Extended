using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SortArrayOfStrings
{
    public class SortArrayOfStrings
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(' ').ToArray();

            Array.Sort(array);

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
