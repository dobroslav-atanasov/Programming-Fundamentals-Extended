using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _01.DayOfWeek
{
    public class DayOfWeek
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var date = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
