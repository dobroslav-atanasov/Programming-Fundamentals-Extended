using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.WordEncounter
{
    public class WordEncounter
    {
        public static void Main()
        {
            var filter = Console.ReadLine();
            var symbol = filter[0];
            var digit = int.Parse(filter[1].ToString());

            var words = new List<string>();

            var pattern = @"(?<!.)[A-Z](.*)[.!?](?!.)";
            var regex = new Regex(pattern);

            var input = Console.ReadLine();

            while (input != "end")
            {
                var isValid = regex.IsMatch(input);

                if (isValid)
                {
                    var wordPattern = @"\w+";
                    var wordsRegex = new Regex(wordPattern);
                    var wordsInSentence = wordsRegex.Matches(input);

                    foreach (Match word in wordsInSentence)
                    {
                        var currentWord = word.Groups[0].Value;
                        var count = 0;

                        for (int i = 0; i < currentWord.Length; i++)
                        {
                            if (currentWord[i] == symbol)
                            {
                                count++;
                            }
                        }

                        if (count >= digit)
                        {
                            words.Add(currentWord);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", words));            
        }
    }
}
