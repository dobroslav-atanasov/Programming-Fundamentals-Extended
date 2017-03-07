namespace _06.Winecraft
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Winecraft
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
                       
            while(list.Count > n)
            {
                for (int i = 1; i <= n; i++)
                {
                    IncrementAllElement(list);

                    for (int j = 0; j < list.Count; j++)
                    {
                        ProcessElement(list, j);
                    }
                }

                RemoveElement(list, n);
            }

            Console.WriteLine(string.Join(" ", list));
        }

        static void ProcessElement(List<int> list, int j)
        {
            var isFirstElement = j == 0;
            var isLastElement = j == list.Count - 1;

            if (!isFirstElement && !isLastElement)
            {
                var previousIndex = j - 1;
                var nextIndex = j + 1;
                var isGreater = list[j] > list[previousIndex] && list[j] > list[nextIndex];

                if (isGreater)
                {
                    list[j]--;

                    if (list[previousIndex] > 0)
                    {
                        list[j]++;
                        list[previousIndex] = Math.Max(list[previousIndex] - 2, 0);
                    }

                    if (list[nextIndex] > 0)
                    {
                        list[j]++;
                        list[nextIndex] = Math.Max(list[nextIndex] - 2, 0);
                    }
                }
            }
        }

        static void IncrementAllElement(List<int> list)
        {
            for (int j = 0; j < list.Count; j++)
            {
                list[j]++;
            }
        }

        static void RemoveElement(List<int> list, int n)
        {
            for (int j = 0; j < list.Count; j++)
            {
                if (list[j] <= n)
                {
                    list.RemoveAt(j);
                    j--;
                }
            }
        }
    }
}
