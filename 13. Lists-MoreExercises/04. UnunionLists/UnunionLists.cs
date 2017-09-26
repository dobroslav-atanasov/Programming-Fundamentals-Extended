namespace _04.UnunionLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UnunionLists
    {
        public static void Main()
        {
            var prime = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            var primeList = prime.Distinct().ToList();

            for (int i = 1; i <= n; i++)
            {
                var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                for (int j = 0; j < list.Count; j++)
                {
                    if (!primeList.Contains(list[j]))
                    {
                        primeList.Add(list[j]);
                    }
                    else
                    {
                        primeList.Remove(list[j]);
                    }
                }
            }

            primeList.Sort();

            Console.WriteLine(string.Join(" ", primeList));
        }
    }
}
