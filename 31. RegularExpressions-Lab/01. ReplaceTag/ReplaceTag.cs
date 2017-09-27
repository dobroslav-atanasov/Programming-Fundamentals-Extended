using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.ReplaceTag
{
    public class ReplaceTag
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            while (text != "end")
            {
                var pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                var regex = new Regex(pattern);

                var replacement = @"[URL href=$1]$2[/URL]";
                var result = Regex.Replace(text, pattern, replacement);

                Console.WriteLine(result);

                text = Console.ReadLine();
            }
        }
    }
}
