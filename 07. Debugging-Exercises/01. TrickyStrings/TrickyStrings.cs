using System;

namespace _01.TrickyStrings
{
    public class TrickyStrings
    {
        public static void Main()
        {
            string delimiter = Console.ReadLine();
            int numberOfStrings = int.Parse(Console.ReadLine());

            var result = string.Empty;
            var currentString = string.Empty;
            for (int i = 1; i <= numberOfStrings; i++)
            {
                currentString = Console.ReadLine();
                if (i == numberOfStrings)
                {
                    result += currentString;
                }
                else
                {
                    result += currentString + delimiter;
                }
            }

            Console.WriteLine(result);
        }
    }
}
