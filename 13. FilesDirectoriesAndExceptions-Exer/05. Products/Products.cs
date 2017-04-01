namespace _03.Hornet_Assault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            //READ THE TWO INPUT SEQUENCES
            //READ THEM AS LONG TO AVOID OVERFLOWS
            long[] beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            //HORNETS GET REMOVED WHEN DEAD, WHICH IS WHY WE NEED A LIST HERE
            List<long> hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            //THE LOOP THAT GOES THROUGH THE BEEHIVES
            for (int i = 0; i < beehives.Length; i++)
            {
                //IF ALL HORNETS DIED, BREAK THE LOOP
                //MIGHT BE AN EDGE CASE ??
                if (hornets.Count == 0)
                {
                    break;
                }

                //TAKE THE CURRENT BEEHIVE BEES COUNT
                long beehiveCount = beehives[i];

                long hornetPower = SumHornetsPower(hornets); //SUM ALL HORNETS POWERS WITH A SIMPLE METHOD

                //THE COOL WAY => WITH LINQ
                //long hornetPower = hornets.Sum();

                //KILL BEES EQUAL TO THE HORNETS POWER, DECREASE THE INTEGER AT THAT POSITION
                beehives[i] -= hornetPower;

                //IF THE BEES ARE MORE OR EQUAL TO THE HORNETS POWER, REMOVE THE FIRST ELEMENT, BECAUSE THE FIRST HORNET DIES
                if (beehiveCount >= hornetPower)
                {
                    hornets.RemoveAt(0);
                }
            }

            //PRINT THE WINNING SIDE WITH A SIMPLE METHOD
            PrintWinningSide(beehives, hornets);

            //THE COOL WAY => WITH LINQ
            //if (beehives.Any(bh => bh > 0))
            //{
            //    Console.WriteLine(string.Join(" ", beehives.Where(bh => bh > 0)));
            //}
            //else
            //{
            //    Console.WriteLine(string.Join(" ", hornets));
            //}
        }

        //SUMS THE ELEMENTS OF A SEQUENCE OF TYPE - LONG
        private static long SumHornetsPower(List<long> hornets)
        {
            //CREATE THE RESULT VARIABLE
            long sum = 0L;

            //FOREACH THE COLLECTION
            foreach (var hornet in hornets)
            {
                //ADD EVERY ELEMENT TO THE SUM
                sum += hornet;
            }

            //RETURN THE RESULT
            return sum;
        }

        //PRINT THE WINNING SIDE
        //CHECKS THE COLLECTION OF BEEHIVES IF IT HAS ANY ALIVE ONES
        //IF IT DOES, PRINT THEM
        //ELSE, PRINT THE COLLECTION OF HORNETS
        private static void PrintWinningSide(long[] beehives, List<long> hornets)
        {
            //CREATE A SIMPLE LIST OF LONG, TO STORE THE ALIVE BEEHIVES
            List<long> aliveBeehives = new List<long>();

            //FOREACH THROUGH THE COLLECTION OF BEEHIVES
            foreach (var beehive in beehives)
            {
                //ADD EVERY ALIVE BEEHIVE TO THE COLLECTION OF ALIVE BEEHIVES
                if (beehive > 0)
                {
                    aliveBeehives.Add(beehive);
                }
            }

            //IF THERE ARE ANY ALIVE BEEHIVES PRINT THEM
            //ELSE, PRINT THE HORNETS
            //IN BOTH CASES, JOIN THE COLLECTIONS BY SPACE 
            if (aliveBeehives.Count > 0)
            {
                Console.WriteLine(string.Join(" ", aliveBeehives));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}

