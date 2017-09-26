using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.JapaneseRoulette
{
    public class JapaneseRoulette
    {
        public static void Main()
        {
            var cylinder = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var players = Console.ReadLine().Split(' ').ToList();

            int bullet = 0;
            int position = 2;
            bool isDead = false;
            int numberOfPlayer = 0;
            
            foreach (var item in cylinder)
            {
                if (item > 0)
                {
                    bullet = item;
                }
            }

            for (int i = 0; i < players.Count; i++)
            {
                var player = players[i].Split(',').ToList();
                int strength = int.Parse(player[0]);
                string direction = player[1];

                if (direction == "Left")
                {
                    while (strength > 0)
                    {
                        position++;
                        strength--;
                        if (position > cylinder.Count - 1)
                        {
                            position = 0;
                        }
                    }
                }
                else if (direction == "Right")
                {
                    while (strength > 0)
                    {
                        position--;
                        strength--;
                        if (position < 0)
                        {
                            position = cylinder.Count - 1;
                        }
                    }
                }

                if (cylinder[position] == bullet)
                {
                    numberOfPlayer = i;
                    isDead = true;
                    break;
                }

                position--;
                if (position < 0)
                {
                    position = cylinder.Count - 1;
                }
            }

            if (isDead)
            {
                Console.WriteLine($"Game over! Player {numberOfPlayer} is dead.");
            }
            else
            {
                Console.WriteLine("Everybody got lucky!");
            }
        }
    }
}
