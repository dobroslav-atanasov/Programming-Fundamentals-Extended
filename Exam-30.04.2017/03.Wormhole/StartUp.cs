namespace Wormhole
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var moves = 0;

            for (var i = 0; i < list.Count; i++)
                if (list[i] == 0)
                {
                    moves++;
                }
                else
                {
                    moves++;
                    var currentIndex = i;
                    int currentNumber = list[i];
                    list[i] = 0;
                    list[currentNumber] = 0;
                    i = currentNumber;
                }

            Console.WriteLine(moves);
        }
    }
}