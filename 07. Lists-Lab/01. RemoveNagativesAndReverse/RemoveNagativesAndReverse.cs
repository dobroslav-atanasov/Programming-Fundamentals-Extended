namespace _01.RemoveNagativesAndReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveNagativesAndReverse
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var result = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] >= 0)
                {
                    result.Add(list[i]);
                }
            }

            result.Reverse();
            
            if (result.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
