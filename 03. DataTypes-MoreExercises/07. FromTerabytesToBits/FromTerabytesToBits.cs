namespace _07.FromTerabytesToBits
{
    using System;

    public class FromTerabytesToBits
    {
        public static void Main()
        {
            double terabytes = double.Parse(Console.ReadLine());

            var bits = terabytes * 1024 * 1024 * 1024 * 1024 * 8;

            Console.WriteLine(bits);
        }
    }
}
