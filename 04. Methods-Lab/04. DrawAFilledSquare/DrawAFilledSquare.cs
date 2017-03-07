using System;

namespace _04.DrawAFilledSquare
{
    public class DrawAFilledSquare
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintTopBottom(n);

            for (int i = 1; i < n - 1; i++)
            {
                PrintMiddle(n);
            }
            
            PrintTopBottom(n);
        }

        public static void PrintMiddle(int n)
        {
            Console.Write("-");
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }

        public static void PrintTopBottom(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
    }
}
