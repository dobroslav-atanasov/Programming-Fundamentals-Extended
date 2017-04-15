using System;

namespace _01.CharityMarathon
{
    public class CharityMarathon
    {
        public static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            long runners = int.Parse(Console.ReadLine());
            int laps = int.Parse(Console.ReadLine());
            long length = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double moneyPerKilometer = double.Parse(Console.ReadLine());

            var maxRunners = days * capacity;
            var totalRunner = Math.Min(runners, maxRunners);

            var totalMeters = totalRunner * laps * length;
            var totalKilometer = totalMeters / 1000;
            var totalMoney = totalKilometer * moneyPerKilometer;

            Console.WriteLine($"Money raised: {totalMoney:F2}");
        }
    }
}
