namespace CharityMarathon
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var days = int.Parse(Console.ReadLine());
            long runners = int.Parse(Console.ReadLine());
            var laps = int.Parse(Console.ReadLine());
            long length = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double moneyPerKilometer = double.Parse(Console.ReadLine());

            int maxRunners = days * capacity;
            long totalRunner = Math.Min(runners, maxRunners);

            var totalMeters = totalRunner * laps * length;
            var totalKilometer = totalMeters / 1000;
            var totalMoney = totalKilometer * moneyPerKilometer;

            Console.WriteLine($"Money raised: {totalMoney:F2}");
        }
    }
}