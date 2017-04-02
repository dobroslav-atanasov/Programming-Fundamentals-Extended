using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Placeholders
{
    public class Placeholders
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var sb = new StringBuilder();
            
            while (input != "end")
            {
                var tokens = input.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var sentence = tokens[0].Trim();
                var words = tokens[1].Trim().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < words.Length; i++)
                {
                    sentence = sentence.Replace("{" + $"{i}" + "}", words[i]);
                }

                sb.AppendLine(sentence);

                input = Console.ReadLine();
            }

            Console.WriteLine(sb);
        }
    }
}
