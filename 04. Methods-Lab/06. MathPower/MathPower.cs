using System;

namespace _06.MathPower
{
    public class MathPower
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            var result = CalculateMathPower(number, power);
            Console.WriteLine(result);
        }

        public static double CalculateMathPower(double number, int power)
        {
            var result = Math.Pow(number, power);

            return result;
        }
    }
}
