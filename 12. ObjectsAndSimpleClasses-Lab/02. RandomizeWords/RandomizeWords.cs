using System;
using System.Linq;

namespace _02.RandomizeWords
{
    public class RandomizeWords
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split(' ').ToArray();
            var random = new Random();

            for (int i = 0; i < list.Length; i++)
            {
                var currentWord = list[i];
                var randomPosition = random.Next(0, list.Length);

                var temp = list[randomPosition];
                list[randomPosition] = currentWord;
                list[i] = temp; 
            }

            foreach (var word in list)
            {
                Console.WriteLine(word);
            }
        }
    }
}
