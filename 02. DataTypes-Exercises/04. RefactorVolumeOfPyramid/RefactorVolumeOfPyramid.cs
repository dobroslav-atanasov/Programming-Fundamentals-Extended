namespace _04.RefactorVolumeOfPyramid
{
    using System;

    public class RefactorVolumeOfPyramid
    {
        public static void Main(string[] args)
        {
            double length = 0;
            double width = 0;
            double height = 0;
           
            Console.Write("Length: ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            height = double.Parse(Console.ReadLine());

            double volume = (length * width * height) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);

        }
    }
}
