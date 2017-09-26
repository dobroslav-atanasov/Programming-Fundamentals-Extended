namespace _01.SpecialNumbers
{
    using System;

    public class SpecialNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                var num = i;
                var sum = 0;
                while (num != 0)
                {
                    var lastDigit = num % 10;
                    sum += lastDigit;
                    num = num / 10;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
