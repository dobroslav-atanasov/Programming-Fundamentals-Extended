namespace _06.IncrementVariable
{
    using System;

    public class IncrementVariable
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            byte variable = 0;
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                variable++;
                if (variable == 0)
                {
                    count++;
                }
            }

            Console.WriteLine(variable);
            Console.WriteLine("Overflowed {0} times", count);
        }
    }
}
