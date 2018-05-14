namespace Ladybugs
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int fieldSize = int.Parse(Console.ReadLine());
            var indexesOfLadybugs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var field = new int[fieldSize];

            foreach (var indexOfLadybugs in indexesOfLadybugs)
            {
                if (indexOfLadybugs < 0 || indexOfLadybugs >= fieldSize)
                {
                    continue;
                }

                field[indexOfLadybugs] = 1;
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                var tokens = input.Split(' ').ToArray();
                var index = int.Parse(tokens[0]);
                var direction = tokens[1];
                var flyLength = int.Parse(tokens[2]);

                if (index < 0 || index >= fieldSize)
                {
                    continue;
                }

                if (field[index] == 0)
                {
                    continue;
                }

                var position = index;
                field[index] = 0;

                while (true)
                {
                    if (direction == "right")
                    {
                        position += flyLength;
                    }
                    else
                    {
                        position -= flyLength;
                    }

                    if (position < 0 || position >= fieldSize)
                    {
                        break;
                    }

                    if (field[position] == 1)
                    {
                        continue;
                    }
                    else
                    {
                        field[position] = 1;
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}