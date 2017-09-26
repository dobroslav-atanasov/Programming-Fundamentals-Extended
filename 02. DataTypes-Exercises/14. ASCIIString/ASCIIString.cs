namespace _14.ASCIIString
{
    using System;

    public class ASCIIString
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string name = "";

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                name += (char)number;
            }

            Console.WriteLine(name);
        }
    }
}
