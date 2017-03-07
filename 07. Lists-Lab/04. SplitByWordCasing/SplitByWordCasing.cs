namespace _04.SplitByWordCasing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SplitByWordCasing
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split(new[] { ',', ';', ':', '.', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']', ' '}, StringSplitOptions.RemoveEmptyEntries).ToList();

            var lowerCase = new List<string>();
            var mixedCase = new List<string>();
            var upperCase = new List<string>();

            foreach (var word in list)
            {
                bool isLower = true;
                bool isUpper = true;

                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLower(word[i]))
                    {
                        isUpper = false;
                    }
                    else if (char.IsUpper(word[i]))
                    {
                        isLower = false;
                    }
                    else
                    {
                        isUpper = false;
                        isLower = false;
                    }
                }
                if (isLower)
                {
                    lowerCase.Add(word);
                }
                else if (isUpper)
                {
                    upperCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}
