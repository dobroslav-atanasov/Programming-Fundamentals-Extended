namespace _04.FloatOrInteger
{
    using System;

    public class FloatOrInteger
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round(number));
        }
    }
}
