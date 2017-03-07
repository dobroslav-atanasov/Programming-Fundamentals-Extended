using System;

namespace _08.StringEncryption
{
    public class StringEncryption
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string result = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());

                int firstDigit = 0;
                int lastDigit = 0;
                int number = (int)symbol;

                if (number <= 99)
                {
                    lastDigit = number % 10;
                    firstDigit = number / 10;
                }
                else
                {
                    lastDigit = number % 10;
                    firstDigit = number / 100;
                }

                result += (char)(number + lastDigit);
                result += firstDigit;
                result += lastDigit;
                result += (char)(number - firstDigit);
            }

            Console.WriteLine(result);
        }
    }
}
