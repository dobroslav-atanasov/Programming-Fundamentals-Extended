using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CapitalizeWords
{
    public class CapitalizeWords
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToLower();

            while (input != "end")
            {
                var tokens = input.Split(new char[] { ' ', '.', '!', ',', '?', '(', ')', '{', '}', '[', ']', ':', ';', '-', '/' }, StringSplitOptions.RemoveEmptyEntries);
                var words = new List<string>();

                foreach (var word in tokens)
                {
                    var firstLetter = word.Substring(0, 1).ToUpper();
                    var secondPart = word.Substring(1);

                    var newWord = firstLetter + secondPart;

                    words.Add(newWord);
                }

                Console.WriteLine(string.Join(", ", words));

                input = Console.ReadLine().ToLower();
            }
        }
    }
}
