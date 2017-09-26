namespace _15.Calculator
{
    using System;

    public class Calculator
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());

            if (symbol == "+")
            {
                Console.WriteLine($"{a} + {b} = {a + b}");
            }
            else if (symbol == "-")
            {
                Console.WriteLine($"{a} - {b} = {a - b}");
            }
            else if (symbol == "*")
            {
                Console.WriteLine($"{a} * {b} = {a * b}");
            }
            else if (symbol == "/")
            {
                Console.WriteLine($"{a} / {b} = {a / b}");
            }
        }
    }
}
