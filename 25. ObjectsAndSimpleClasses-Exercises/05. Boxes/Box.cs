namespace _05.Boxes
{
    public class Box
    {
        public Point UpperLeft { get; set; }

        public Point UpperRight { get; set; }

        public Point BottomLeft { get; set; }

        public Point BottomRight { get; set; }

        public double Width { get { return Point.CalculateDistance(UpperLeft, UpperRight); } }

        public double Height { get { return Point.CalculateDistance(UpperLeft, BottomLeft); } }

        public static double CalculatePerimeter(double width, double height)
        {
            double perimeter = (width * 2 + height * 2);

            return perimeter;
        }

        public static double CalculateArea(double width, double height)
        {
            double area = width * height;

            return area;
        }
    }
}
