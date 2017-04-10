using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Numerics;

namespace _01.SinoTheWalker
{
    public class SinoTheWalker
    {
        public static void Main()
        {
            var time = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            int numberOfSteps = int.Parse(Console.ReadLine()) % 86400;
            int timeInSecondsForStep = int.Parse(Console.ReadLine()) % 86400;

            long totalSeconds = numberOfSteps * timeInSecondsForStep;
            var totalTime = time.AddSeconds(totalSeconds);
            var result = totalTime.TimeOfDay.ToString();

            Console.WriteLine($"Time Arrival: {result}");
        }
    }
}
