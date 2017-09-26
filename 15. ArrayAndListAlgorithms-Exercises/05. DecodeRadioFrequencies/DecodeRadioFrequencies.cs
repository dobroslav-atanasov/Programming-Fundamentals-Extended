using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.DecodeRadioFrequencies
{
    public class DecodeRadioFrequencies
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            
            var first = 0;
            var decimalSecond = 0M;
            var second = 0;

            var list = new List<char>();

            for (int i = 0; i < array.Length; i++)
            {
                first = (int)array[i];
                decimalSecond = (decimal)(array[i] - first);
                string point = decimalSecond.ToString();
                second = int.Parse(point.Remove(0, 2));

                if (first != 0)
                {
                    if (i == 0)
                    {
                        list.Add((char)first);
                    }
                    else
                    {
                        list.Insert(i, (char)first);
                    }
                }
                if (second != 0)
                {
                    if (i == 0)
                    {
                        list.Add((char)second);
                    }
                    else
                    {
                        list.Insert(i + 1, (char)second);
                    }
                }
            }

            Console.WriteLine(string.Join("", list));
        }
    }
}
