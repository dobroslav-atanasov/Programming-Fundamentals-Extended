namespace _12.VariableInHexadecimalFormat
{
    using System;

    public class VariableInHexadecimalFormat
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var number = Convert.ToInt32(input, 16);

            Console.WriteLine(number);
        }
    }
}
