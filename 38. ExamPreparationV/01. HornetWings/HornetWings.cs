using System;

namespace _01.HornetWings
{
    public class HornetWings
    {
        public static void Main()
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distanceForWingFlaps = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            double distance = (wingFlaps / 1000) * distanceForWingFlaps;
            double hornetFlaps = wingFlaps / 100;
            double rests = (wingFlaps / endurance) * 5;

            var total = hornetFlaps + rests;

            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine($"{total:F0} s.");
        }
    }
}
