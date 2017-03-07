namespace _17.CypherRoulette
{
    using System;
    using System.Collections.Generic;

    public class CypherRoulette
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string text = string.Empty;
            int count = 0;
            string previousWord = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                string word = Console.ReadLine();
                if (word == previousWord)
                {
                    if (word == "spin")
                    {
                        text = string.Empty;
                        i--;
                    }
                    text = string.Empty;
                }
                else
                {
                    if (word == "spin")
                    {
                        i--;
                        count++;
                    }
                    else
                    {
                        if (count % 2 == 0)
                        {
                            text += word;
                        }
                        else if (count % 2 != 0)
                        {
                            text = word + text;
                        }
                    }
                }

                previousWord = word;
            }

            Console.WriteLine(text);
        }
    }
}