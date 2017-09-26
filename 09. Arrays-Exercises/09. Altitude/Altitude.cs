namespace _09.Altitude
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Altitude
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(' ').ToArray();
            var numbers = new double[array.Length];
            
            for (int i = 0; i < numbers.Length; i += 2)
            {
                numbers[i] = double.Parse(array[i]);
            }

            var sum = 0.0;

            for (int i = 2; i < numbers.Length; i++)
            {
                if (array[i - 1] == "up")
                {
                    sum += numbers[i];
                }
                else if(array[i - 1] == "down")
                {
                    sum -= numbers[i];
                }
            }

            var altitude = numbers[0] + sum;

            if (altitude > 0)
            {
                Console.WriteLine($"got through safely. current altitude: {altitude}m");
            }
            else
            {
                Console.WriteLine("crashed");
            }
        }
    }
}
