using System;

namespace _01.MultiplyEvensByOdds
{
    public class MultiplyEvensByOdds
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int evenOddProduct = GetMultipleOfEvensAndOdds(n);
            Console.WriteLine(evenOddProduct);
        }

        public static int GetMultipleOfEvensAndOdds(int n)
        {
            int product = GetSumOfOddDigits(n) * GetSumOfEvenDigits(n);
            return product;
        }

        public static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            while (Math.Abs(n) > 0)
            {
                int currentDigit = Math.Abs(n) % 10;
                if (currentDigit % 2 == 0)
                {
                    sum += currentDigit;
                }
                n /= 10;
            }

            return sum;
        }

        public static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            while (Math.Abs(n) > 0)
            {
                int currentDigit = Math.Abs(n) % 10;
                if (currentDigit % 2 != 0)
                {
                    sum += currentDigit;
                }
                n /= 10;
            }

            return sum;
        }
    }
}
