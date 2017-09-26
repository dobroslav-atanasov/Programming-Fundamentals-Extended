using System;

namespace _02.MinMethod
{
    public class MinMethod
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int first = GetMin(a, b);
            int min = GetMin(first, c);

            Console.WriteLine(min);
        }

        public static int GetMin(int a, int b)
        {
            if (a <= b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
