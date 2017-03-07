using System;

namespace _05.CalculateTriangleArea
{
    public class CalculateTriangleArea
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            var result = CalculateArea(a, b);
            Console.WriteLine(result);
        }

        public static double CalculateArea(double a, double b)
        {
            double area = a * b / 2;
            return area;
        }
    }
}
