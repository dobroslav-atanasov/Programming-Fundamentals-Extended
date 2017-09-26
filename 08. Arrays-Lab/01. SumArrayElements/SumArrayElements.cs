namespace _01.SumArrayElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumArrayElements
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var array = new int[n];
            var sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
            }

            Console.WriteLine(sum);
        }
    }
}
