using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.MelrahShake
{
    public class MelrahShake
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = Console.ReadLine();
            
            var regex = new Regex(Regex.Escape(pattern));
            var matches = regex.Matches(input);

            while (true)
            {
                if (matches.Count >= 2 && pattern.Length > 0)
                {
                    var first = input.IndexOf(pattern);
                    var last = input.LastIndexOf(pattern);

                    input = input.Remove(last, pattern.Length);
                    input = input.Remove(first, pattern.Length);

                    Console.WriteLine("Shaked it.");

                    var patternIndex = pattern.Length / 2;
                    pattern = pattern.Remove(patternIndex, 1);
                }
                else
                {
                    Console.WriteLine("No shake.");
                    break;
                }

                regex = new Regex(Regex.Escape(pattern));
                matches = regex.Matches(input);
            }

            Console.WriteLine(input);
        }
    }
}
