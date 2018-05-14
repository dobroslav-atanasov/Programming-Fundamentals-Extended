namespace SinoTheWalker
{
    using System;
    using System.Globalization;

    public class StartUp
    {
        public static void Main()
        {
            var time = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            var numberOfSteps = int.Parse(Console.ReadLine()) % 86400;
            var timeInSecondsForStep = int.Parse(Console.ReadLine()) % 86400;

            long totalSeconds = numberOfSteps * timeInSecondsForStep;
            var totalTime = time.AddSeconds(totalSeconds);
            var result = totalTime.TimeOfDay.ToString();

            Console.WriteLine($"Time Arrival: {result}");
        }
    }
}