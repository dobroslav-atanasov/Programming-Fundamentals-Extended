namespace _03.EqualSumAfterExtraction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EqualSumAfterExtraction
    {
        public static void Main()
        {
            var firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var firstSum = 0;
            var secondSum = 0;

            for (int i = 0; i < firstList.Count; i++)
            {
                if (secondList.Contains(firstList[i]))
                {
                    secondList.Remove(firstList[i]);
                }
            }

            for (int i = 0; i < firstList.Count; i++)
            {
                firstSum += firstList[i];
            }

            for (int i = 0; i < secondList.Count; i++)
            {
                secondSum += secondList[i];
            }

            if (firstSum == secondSum)
            {
                Console.WriteLine($"Yes. Sum: {firstSum}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Max(firstSum, secondSum) - Math.Min(firstSum, secondSum)}");
            }
        }
    }
}
