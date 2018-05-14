namespace Wormtest
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int wormsLength = int.Parse(Console.ReadLine());
            decimal wormsWidth = decimal.Parse(Console.ReadLine());

            int wormsLengthINCM = wormsLength * 100;

            if (wormsWidth != 0)
            {
                decimal reminder = (decimal)wormsLengthINCM % wormsWidth;
                if (reminder == 0)
                {
                    decimal divideZero = wormsWidth * wormsLengthINCM;
                    Console.WriteLine($"{divideZero:F2}");
                }
                else
                {
                    decimal percent = (wormsLengthINCM / wormsWidth) * 100;
                    Console.WriteLine($"{percent:F2}%");
                }
            }
            else
            {
                decimal divideZero = wormsWidth * wormsLengthINCM;
                Console.WriteLine($"{divideZero:F2}");
            }
        }
    }
}