namespace _04.Transport
{
    using System;

    public class Transport
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int capacity = 4 + 8 + 12;
            int courses = (int)Math.Ceiling((double)n / capacity);

            Console.WriteLine(courses);
        }
    }
}
