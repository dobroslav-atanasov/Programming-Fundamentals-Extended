namespace _06.StuckZipper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StuckZipper
    {
        public static void Main()
        {
            var firstList = Console.ReadLine().Split(' ').ToList();
            var secondList = Console.ReadLine().Split(' ').ToList();

            int numberDigit = 0;
            var minDigitFirst = new List<int>();
            var minDigitSecond = new List<int>();

            for (int i = 0; i < firstList.Count; i++)
            {
                if (firstList[i].Contains("-"))
                {
                    numberDigit = firstList[i].Length - 1;
                }
                else
                {
                    numberDigit = firstList[i].Length;
                }
                minDigitFirst.Add(numberDigit);
            }

            for (int i = 0; i < secondList.Count; i++)
            {
                if (secondList[i].Contains("-"))
                {
                    numberDigit = secondList[i].Length - 1;
                }
                else
                {
                    numberDigit = secondList[i].Length;
                }
                minDigitSecond.Add(numberDigit);
            }

            var minDigit = 0;

            if (minDigitFirst.Min() >= minDigitSecond.Min())
            {
                minDigit = minDigitSecond.Min();
            }
            else
            {
                minDigit = minDigitFirst.Min();
            }

            for (int i = firstList.Count - 1; i >= 0; i--)
            {
                if (firstList[i].Contains("-"))
                {
                    if (firstList[i].Length - 1 > minDigit)
                    {
                        firstList.Remove(firstList[i]);
                    }
                }
                else
                {
                    if (firstList[i].Length > minDigit)
                    {
                        firstList.Remove(firstList[i]);
                    }
                }                
            }

            for (int i = secondList.Count - 1; i >= 0; i--)
            {
                if (secondList[i].Contains("-"))
                {
                    if (secondList[i].Length - 1 > minDigit)
                    {
                        secondList.Remove(secondList[i]);
                    }
                }
                else
                {
                    if (secondList[i].Length > minDigit)
                    {
                        secondList.Remove(secondList[i]);
                    }
                }                
            }
            
            var result = new List<string>();

            for (int i = 0; i < Math.Max(firstList.Count, secondList.Count); i++)
            {
                if (i < secondList.Count)
                {
                    result.Add(secondList[i]);
                }
                if (i < firstList.Count)
                {
                    result.Add(firstList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
