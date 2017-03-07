namespace _16.TrickyStrings
{
    using System;

    public class TrickyStrings
    {
        public static void Main()
        {
            string delimiter = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string text = "";

            for (int i = 1; i <= n; i++)
            {
                string word = Console.ReadLine();
                if (i == n)
                {
                    text += word;
                }
                else
                {
                    text += word + delimiter;
                }
            }

            Console.WriteLine(text);
        }
    }
}
