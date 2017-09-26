using System;
using System.Numerics;

namespace _03.BigFactorial
{
    public class BigFactorial
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
