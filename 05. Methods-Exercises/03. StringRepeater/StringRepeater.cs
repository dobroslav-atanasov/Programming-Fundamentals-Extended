using System;

namespace _03.StringRepeater
{
    public class StringRepeater
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());

            string result = RepeaterString(text, repeat);

            Console.WriteLine(result);
        }

        public static string RepeaterString(string text, int repeat)
        {
            string result = "";

            for (int i = 1; i <= repeat; i++)
            {
                result += text;
            }

            return result;
        }
    }
}
