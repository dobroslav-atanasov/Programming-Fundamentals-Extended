namespace _05.DistanceOfStars
{
    using System;

    public class DistanceOfStars
    {
        public static void Main()
        {
            decimal lightyear = 9450000000000M;
            decimal fromEarthToNearstStar = 4.22M * lightyear;
            decimal centerOfGalaxy = 26000M * lightyear;
            decimal diameterMilkyWay = 100000M * lightyear;
            decimal fromEarthToObservable = 46500000000M * lightyear;

            Console.WriteLine("{0:e2}", fromEarthToNearstStar);
            Console.WriteLine("{0:e2}", centerOfGalaxy);
            Console.WriteLine("{0:e2}", diameterMilkyWay);
            Console.WriteLine("{0:e2}", fromEarthToObservable);
        }
    }
}
