﻿namespace _01.TimeSinceBirthday
{
    using System;

    public class TimeSinceBirthday
    {
        public static void Main()
        {
            byte years = byte.Parse(Console.ReadLine());

            int days = years * 365;
            int hours = days * 24;
            long minutes = hours * 60;

            Console.WriteLine($"{years} years = {days} days = {hours} hours = {minutes} minutes."); 
        }
    }
}
