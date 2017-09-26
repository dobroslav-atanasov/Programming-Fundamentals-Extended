using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.IncreasingCrisis
{
    public class IncreasingCrisis
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var list = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                var sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                int rightMostElement = 0;
                int position = 0;
                bool isBreak = false;

                if (list.Count == 0)
                {
                    for (int j = 0; j < sequence.Count; j++)
                    {
                        list.Add(sequence[j]);
                    }
                }
                else
                {
                    for (int j = 0; j < sequence.Count; j++)
                    {
                        for (int k = 0; k < list.Count; k++)
                        {
                            if (sequence[j] > list[k])
                            {
                                rightMostElement = list[k];
                                position = list.IndexOf(rightMostElement);
                            }
                            else if (sequence[j] == list[k])
                            {
                                position++;
                            }
                        }
                        break;
                    }

                    list.InsertRange(position + 1, sequence);
                }

                int breakElement = 0;
                int breakPostion = 0;

                for (int j = 1; j < list.Count; j++)
                {
                    if (list[j] < list[j - 1])
                    {
                        breakElement = list[j];
                        breakPostion = list.LastIndexOf(breakElement);
                        isBreak = true;
                        break;
                    }
                }

                if (isBreak)
                {
                    for (int j = list.Count - 1; j >= breakPostion; j--)
                    {
                        list.RemoveAt(j);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
