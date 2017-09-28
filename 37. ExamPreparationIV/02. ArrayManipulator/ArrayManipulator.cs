using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ArrayManipulator
{
    public class ArrayManipulator
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var inputParts = input.Split(' ');
                var command = inputParts[0];

                switch (command)
                {
                    case "exchange":
                        int index = int.Parse(inputParts[1]);

                        if (index < 0 || index >= array.Length)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }

                        array = Exchange(array, index);
                        break;
                    case "max":
                    case "min":
                        string commandMinOrMax = inputParts[0];
                        string evenOrOdd = inputParts[1];
                        Console.WriteLine(MaxOrMin(array, commandMinOrMax, evenOrOdd));
                        break;                        
                    case "first":
                    case "last":
                        var commandFirstOrLast = inputParts[0];
                        var count = int.Parse(inputParts[1]);
                        var commandEvenOrOdd = inputParts[2];
                        Console.WriteLine(FirstOrLast(array, commandFirstOrLast, count, commandEvenOrOdd));
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        private static string FirstOrLast(int[] array, string commandFirstOrLast, int count, string commandEvenOrOdd)
        {
            if (count > array.Length)
            {
                return "Invalid count";
            }

            int type = commandEvenOrOdd == "odd" ? 1 : 0;
            var filter = array.Where(x => x % 2 == type).ToArray();

            return commandFirstOrLast == "first" ? $"[{string.Join(", ", filter.Take(count))}]" : $"[{string.Join(", ", filter.Reverse().Take(count).Reverse())}]";
        }

        private static string MaxOrMin(int[] array, string commandMinOrMax, string evenOrOdd)
        {
            int type = evenOrOdd == "odd" ? 1 : 0;
            var filter = array.Where(x => x % 2 == type).ToArray();

            if (!filter.Any())
            {
                return "No matches";
            }

            return commandMinOrMax == "min" ? Array.LastIndexOf(array, filter.Min()).ToString() : Array.LastIndexOf(array, filter.Max()).ToString();
        }

        private static int[] Exchange(int[] array, int index)
        {
            var left = array.Take(index + 1);
            var right = array.Skip(index + 1);

            return right.Concat(left).ToArray();
        }
    }
}
