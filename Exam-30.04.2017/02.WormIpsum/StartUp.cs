namespace WormIpsum
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var sentencePattern = @"^[A-Z][^\.]+\.$";
            var wordPattern = @"[A-z]+";

            while (input != "Worm Ipsum")
            {
                var sentence = Regex.Match(input, sentencePattern);

                if (sentence.Success)
                {
                    var words = Regex.Matches(input, wordPattern);

                    foreach (Match word in words)
                    {
                        var currentWord = word.ToString();
                        var bestChar = default(char);

                        if (currentWord.Length != currentWord.Distinct().Count())
                        {
                            var bestCount = 0;

                            for (int i = 0; i < currentWord.Length; i++)
                            {
                                var count = 0;

                                for (int j = 0; j < currentWord.Length; j++)
                                {
                                    if (currentWord[i] == currentWord[j])
                                    {
                                        count++;
                                        if (count > bestCount)
                                        {
                                            bestCount = count;
                                            bestChar = currentWord[i];
                                        }
                                    }
                                }
                            }

                            if (bestCount >= 2)
                            {
                                var newWord = new string(bestChar, word.Length);
                                input = Regex.Replace(input, word.ToString(), newWord);
                            }
                        }
                    }

                    Console.WriteLine(input);
                }

                input = Console.ReadLine();
            }
        }
    }
}