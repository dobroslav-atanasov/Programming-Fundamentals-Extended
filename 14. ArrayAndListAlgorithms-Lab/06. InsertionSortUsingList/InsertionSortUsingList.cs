namespace _06.InsertionSortUsingList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class InsertionSortUsingList
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var result = new List<int>(list.Count);

            for (int i = 0; i < list.Count; i++)
            {
                var inserted = false;
                var currentElement = list[i];
                for (int j = 0; j < result.Count; j++)
                {
                    var currentListElement = result[j];
                    if (currentElement <= currentListElement)
                    {
                        inserted = true;
                        result.Insert(Math.Max(0, j), currentElement);
                        break;
                    }
                }

                if (!inserted)
                {
                    result.Add(currentElement);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
