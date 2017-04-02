using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SentenceSplit
{
    public class SentenceSplit
    {
        public static void Main()
        {
            var sentence = Console.ReadLine();
            var delimiter = Console.ReadLine();

            var result = sentence.Replace(delimiter, ", ");

            Console.WriteLine($"[{result}]");
        }
    }
}
