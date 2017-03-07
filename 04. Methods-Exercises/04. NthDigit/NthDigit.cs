using System;

namespace _04.NthDigit
{
    public class NthDigit
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            long index = long.Parse(Console.ReadLine());

            long result = FindNthDigit(number, index);
            Console.WriteLine(result);
        }

        public static long FindNthDigit(long number, long index)
        {
            long currentIndex = 1;
            long num = 0;
            long result = 0;

            while (number > 0)
            {
                num = number % 10;

                if (currentIndex == index)
                {
                    result = num;
                    break;
                }

                number /= 10;
                currentIndex++;
            }

            return result;
        }
    }
}
