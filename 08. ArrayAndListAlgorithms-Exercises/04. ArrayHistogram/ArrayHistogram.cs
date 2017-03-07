using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ArrayHistogram
{
    public class ArrayHistogram
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(' ').ToArray();

            var words = new List<string>();
            var count = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                string currentWord = array[i];
                if (words.Contains(currentWord))
                {
                    int wordIndex = words.IndexOf(currentWord);
                    count[wordIndex]++;
                }
                else
                {
                    words.Add(currentWord);
                    count.Add(1);
                }
            }

            bool hasSwapped = true;

            while (hasSwapped)
            {
                hasSwapped = false;

                for (int i = 0; i < count.Count - 1; i++)
                {   
                    if (count[i] < count[i + 1])
                    {
                        int temp = count[i];
                        count[i] = count[i + 1];
                        count[i + 1] = temp;

                        string tempWords = words[i];
                        words[i] = words[i + 1]; 
                        words[i + 1] = tempWords;

                        hasSwapped = true;
                    }
                }
            }
                       
            for (int i = 0; i < words.Count; i++)
            {
                double currentPercent = (count[i] * 100.0) / array.Length;
                Console.WriteLine($"{words[i]} -> {count[i]} times ({currentPercent:F2}%)");
            }
        }
    }
}
