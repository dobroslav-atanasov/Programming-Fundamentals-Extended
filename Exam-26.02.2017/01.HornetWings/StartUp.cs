namespace HornetWings
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var wingFlaps = int.Parse(Console.ReadLine());
            var distanceForWingFlaps = double.Parse(Console.ReadLine());
            var endurance = int.Parse(Console.ReadLine());

            var distance = wingFlaps / 1000 * distanceForWingFlaps;
            double hornetFlaps = wingFlaps / 100;
            double rests = wingFlaps / endurance * 5;

            var total = hornetFlaps + rests;

            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine($"{total:F0} s.");
        }
    }
}