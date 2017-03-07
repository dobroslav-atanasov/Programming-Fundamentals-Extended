namespace _06.PowerPlants
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PowerPlants
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var day = 0;
            var sum = 0;
            var season = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            while (sum > 0)
            {
                for (int dayIndex = 0; dayIndex < array.Length; dayIndex++)
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (dayIndex == i)
                        {
                            array[i] = array[i];
                        }
                        else
                        {
                            array[i] = array[i] - 1;
                            if (array[i] < 0)
                            {
                                array[i] = 0;
                            }
                        }
                    }

                    sum = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        sum += array[i];
                    }
                    day++;

                    if (sum == 0)
                    {
                        break;
                    }
                    if (day % array.Length == 0)
                    {
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] > 0)
                            {
                                array[i]++;
                            }
                        }
                        season++;
                    }
                }
            }

            if (season == 1)
            {
                Console.WriteLine($"survived {day} days ({season} season)");
            }
            else
            {
                Console.WriteLine($"survived {day} days ({season} seasons)");
            }
        }
    }
}
