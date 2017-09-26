using System;
using System.Linq;

namespace _04.DistanceBetweenPoints
{
    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            var firstPointParts = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var secondPointParts = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var firstPoint = new Point
            {
                X = firstPointParts[0],
                Y = firstPointParts[1]
            };

            var secondPoint = new Point
            {
                X = secondPointParts[0],
                Y = secondPointParts[1]
            };

            var distance = CalculateDistance(firstPoint, secondPoint);
            Console.WriteLine($"{distance:F3}");
        }

        public static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            var squareX = Math.Pow(firstPoint.X - secondPoint.X, 2);
            var squareY = Math.Pow(firstPoint.Y - secondPoint.Y, 2);

            var distance = Math.Sqrt(squareX + squareY);

            return distance;
        }
    }
}
