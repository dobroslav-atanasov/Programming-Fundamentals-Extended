namespace _03.ExactProductOfRealNumbers
{
    using System;

    public class ExactProductOfRealNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            decimal product = 1;

            for (int i = 1; i <= n; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                product *= number;
            }

            Console.WriteLine(product);
        }
    }
}
