using System;

namespace _05.IntegerToBase
{
    public class IntegerToBase
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            string result = IntegerBase(number, toBase);
            Console.WriteLine(result);
        }

        public static string IntegerBase(long number, int toBase)
        {
            string result = "";
            long num = number;

            while (num > 0)
            {
                var remainder = num % toBase;
                result = remainder + result;
                num = num / toBase;
            }

            return result;            
        }
    }
}
