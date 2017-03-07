namespace _08.TravellingAtLightSpeed
{
    using System;

    public class TravellingAtLightSpeed
    {
        public static void Main()
        {
            decimal years = decimal.Parse(Console.ReadLine());

            decimal lightyear = 9450000000000;
            decimal kilometers = years * lightyear;
            decimal speedOfLight = 300000;

            decimal seconds = kilometers / speedOfLight;
            decimal minutes = seconds / 60;
            seconds %= 60;
            decimal hours = minutes / 60;
            minutes %= 60;
            decimal days = hours / 24;
            hours %= 24;
            decimal weeks = days / 7;
            days %= 7;

            Console.WriteLine("{0} weeks", (int)weeks);
            Console.WriteLine("{0} days", (int)days);
            Console.WriteLine("{0} hours", (int)hours);
            Console.WriteLine("{0} minutes", (int)minutes);
            Console.WriteLine("{0} seconds", (int)seconds);
        }
    }
}
