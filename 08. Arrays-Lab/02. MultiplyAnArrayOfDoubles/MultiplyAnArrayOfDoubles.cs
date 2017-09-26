namespace _02.MultiplyAnArrayOfDoubles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MultiplyAnArrayOfDoubles
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double n = double.Parse(Console.ReadLine());

            var result = new double[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i] * n;
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
