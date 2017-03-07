namespace _06.EqualSequenceOfElementsInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EqualSequenceOfElementsInArray
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool isTrue = true;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
                    break;
                }
            }

            if (isTrue == true)
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
