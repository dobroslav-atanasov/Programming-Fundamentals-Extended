using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ClosestTwoPoints
{
    public class ClosestTwoPoints
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var points = new Point[n];

            for (int i = 0; i < n; i++)
            {
                var currentPoint = ReadPoint();
                points[i] = currentPoint;
            }

            var minDistance = double.MaxValue;
            Point firstPointResult = null;
            Point secondPointResult = null;

            for (int first = 0; first < points.Length; first++)
            {
                for (int second = first + 1; second < points.Length; second++)
                {
                    var firstPoint = points[first];
                    var secondPoint = points[second];
                    var distance = CalculateDistance(firstPoint, secondPoint);

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        firstPointResult = firstPoint;
                        secondPointResult = secondPoint;
                    }
                }
            }

            Console.WriteLine($"{minDistance:F3}");
            Console.WriteLine(firstPointResult.Print());
            Console.WriteLine(secondPointResult.Print());
            
            //SOLUTION WITH LIST<POINT>

            //int n = int.Parse(Console.ReadLine());

            //var points = new List<Point>();

            //for (int i = 1; i <= n; i++)
            //{
            //    var currentPoint = ReadPoint();
            //    points.Add(currentPoint);
            //}

            //var minDistance = double.MaxValue;
            //Point firstPointResult = null;
            //Point secondPointResult = null;

            //for (int first = 0; first < points.Count; first++)
            //{
            //    for (int second = first + 1; second < points.Count; second++)
            //    {
            //        var firstPoint = points[first];
            //        var secondPoint = points[second];
            //        var distance = CalculateDistance(firstPoint, secondPoint);

            //        if (distance < minDistance)
            //        {
            //            minDistance = distance;
            //            firstPointResult = firstPoint;
            //            secondPointResult = secondPoint;
            //        }
            //    }
            //}

            //Console.WriteLine($"{minDistance:F3}");
            //Console.WriteLine($"({firstPointResult.X}, {firstPointResult.Y})");
            //Console.WriteLine($"({secondPointResult.X}, {secondPointResult.Y})");
        }

        public static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            var squareX = Math.Pow(firstPoint.X - secondPoint.X, 2);
            var squareY = Math.Pow(firstPoint.Y - secondPoint.Y, 2);

            var distance = Math.Sqrt(squareX + squareY);

            return distance;
        }

        public static Point ReadPoint()
        {
            var pointParts = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            return new Point
            {
                X = pointParts[0],
                Y = pointParts[1]
            };
        }
    }
}
