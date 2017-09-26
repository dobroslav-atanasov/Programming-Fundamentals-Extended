using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageCharacterDelimiter
{
    public class AverageCharacterDelimiter
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(' ').ToArray();

            var list = new List<char>();

            for (int i = 0; i < array.Length; i++)
            {
                var element = array[i].ToCharArray();

                for (int j = 0; j < element.Length; j++)
                {
                    list.Add(element[j]);
                }
            }

            var sum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                sum += (int)list[i];
            }

            var average = sum / list.Count;

            var delimiter = (char)average;
            var toUpper = delimiter.ToString();

            Console.WriteLine(string.Join(toUpper.ToUpper(), array));
        }
    }
}
