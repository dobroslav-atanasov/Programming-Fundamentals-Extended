using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Wormhole
{
    public class Wormhole
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var moves = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 0)
                {
                    moves++;
                }
                else
                {
                    moves++;
                    int currentIndex = i;
                    int currentNumber = list[i];
                    list[i] = 0;
                    list[currentNumber] = 0;
                    i = currentNumber;
                }
            }

            Console.WriteLine(moves);
        }
    }
}
