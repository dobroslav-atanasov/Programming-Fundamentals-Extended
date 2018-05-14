namespace EnduranceRally
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var drivers = Console.ReadLine().Split(' ').ToArray();
            var zones = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            foreach (var driver in drivers)
            {
                var symbol = driver.ToCharArray();
                var startFuel = (int) symbol[0];

                var currentFuel = 0.0;
                currentFuel += startFuel;
                var count = 0;

                for (var i = 0; i < zones.Length; i++)
                {
                    count = i;
                    if (indexes.Contains(i))
                        currentFuel += zones[i];
                    else
                        currentFuel -= zones[i];

                    if (currentFuel <= 0)
                        break;
                }

                if (currentFuel > 0)
                    Console.WriteLine($"{driver} - fuel left {currentFuel:F2}");
                else
                    Console.WriteLine($"{driver} - reached {count}");
            }
        }
    }
}