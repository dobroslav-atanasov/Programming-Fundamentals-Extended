namespace _02.AppendLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AppendLists
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split('|').ToList();

            var result = new List<string>();

            list.Reverse();

            foreach (var item in list)
            {
                var nums = item.Split(' ').ToList();
                foreach (var num in nums)
                {
                    if (num != "")
                    {
                        result.Add(num);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
