using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Batteries
{
    public class Batteries
    {
        public static void Main()
        {
            var capcities = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var usageByHour = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int hoursTest = int.Parse(Console.ReadLine());

            for (int i = 0; i < capcities.Length; i++)
            {
                var count = 0;
                for (int hour = 1; hour <= hoursTest; hour++)
                {
                    var use = usageByHour[i] * hour;
                    count++;
                    if (use > capcities[i])
                    {
                        break;
                    }
                }
                
                var power = usageByHour[i] * hoursTest;
                var leftPower = capcities[i] - power;
                if (leftPower >= 0)
                {
                    Console.WriteLine($"Battery {i + 1}: {capcities[i] - power:F2} mAh ({(leftPower / capcities[i]) * 100:F2})%");
                }
                else
                {
                    Console.WriteLine($"Battery {i + 1}: dead (lasted {count} hours)");
                }
                
            }
        }
    }
}
