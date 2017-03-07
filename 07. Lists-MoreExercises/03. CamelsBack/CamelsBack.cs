namespace _03.CamelsBack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CamelsBack
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int m = int.Parse(Console.ReadLine());

            int round = 0;
            int length = list.Count;

            while (length > m)
            {
                list.Remove(list[0]);
                list.Remove(list[list.Count - 1]);                
                round++;
                length = list.Count;
            }

            if (round == 0)
            {
                Console.WriteLine($"already stable: {string.Join(" ", list)}");
            }
            else
            {
                Console.WriteLine($"{round} rounds");
                Console.WriteLine($"remaining: {string.Join(" ", list)}");
            }
        }
    }
}
