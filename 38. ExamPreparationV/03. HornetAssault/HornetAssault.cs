using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HornetAssault
{
    public class HornetAssault
    {
        public static void Main()
        {
            List<long> beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            long hornetsPower = hornets.Sum();
                        
            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornets.Count == 0)
                {
                    break;
                }

                long beesCount = beehives[i];

                beehives[i] -= hornetsPower;

                if (beesCount >= hornetsPower)
                {
                    hornets.RemoveAt(0);
                    hornetsPower = hornets.Sum();
                }
            }

            List<long> alliveBees = new List<long>();

            foreach (var bees in beehives)
            {
                if (bees > 0)
                {
                    alliveBees.Add(bees);
                }
            }

            if (alliveBees.Count > 0)
            {
                Console.WriteLine($"{string.Join(" ", alliveBees)}");
            }
            else
            {
                Console.WriteLine($"{string.Join(" ", hornets)}");
            }
        }
    }
}
