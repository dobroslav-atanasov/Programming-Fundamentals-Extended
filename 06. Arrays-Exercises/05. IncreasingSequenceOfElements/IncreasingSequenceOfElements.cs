namespace _05.IncreasingSequenceOfElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IncreasingSequenceOfElements
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool increasingSequence = true;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    increasingSequence = true;
                }
                else
                {
                    increasingSequence = false;
                    break;
                }
            }

            if (increasingSequence == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
