using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _03.WorldCount
{
    public class WorldCount
    {
        public static void Main()
        {
            var words = File.ReadAllText("words.txt").ToLower().Split();
            var text = File.ReadAllText("text.txt").ToLower().Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);

            var wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                wordCount[word] = 0;
            }

            foreach (var word in text)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
            }

            foreach (var word in wordCount.OrderByDescending(x => x.Value))
            {
                File.AppendAllText("Output.txt", $"{word.Key} - {word.Value + Environment.NewLine}");
            }
        }
    }
}
