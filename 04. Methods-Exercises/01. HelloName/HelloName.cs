using System;

namespace _01.HelloName
{
    public class HelloName
    {
        public static void Main()
        {
            string name = Console.ReadLine();

            PrintHelloName(name);
        }

        public static void PrintHelloName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
