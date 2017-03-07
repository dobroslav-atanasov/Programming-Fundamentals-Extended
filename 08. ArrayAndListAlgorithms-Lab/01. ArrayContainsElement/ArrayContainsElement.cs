namespace _01.ArrayContainsElement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayContainsElement
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int number = int.Parse(Console.ReadLine());

            bool isFound = false;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == number)
                {
                    isFound = true;
                }
            }

            if (isFound)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
