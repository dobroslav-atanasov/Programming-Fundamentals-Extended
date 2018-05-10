namespace CommandInterpreter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<string> list = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var inputParts = input.Split(' ');

                var command = inputParts[0];

                switch (command)
                {
                    case "reverse":
                        int reverseStart = int.Parse(inputParts[2]);
                        int reverseCount = int.Parse(inputParts[4]);

                        if (reverseStart >= 0 && reverseStart < list.Count && reverseCount >= 0 && (reverseStart + reverseCount) <= list.Count)
                        {
                            Reverse(list, reverseStart, reverseCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;

                    case "sort":
                        int sortStart = int.Parse(inputParts[2]);
                        int sortCount = int.Parse(inputParts[4]);

                        if (sortStart >= 0 && sortStart < list.Count && sortCount >= 0 && (sortStart + sortCount) <= list.Count)
                        {
                            Sort(list, sortStart, sortCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;

                    case "rollLeft":
                        int rollLeftTimes = int.Parse(inputParts[1]);

                        if (rollLeftTimes >= 0)
                        {
                            RollLeft(list, rollLeftTimes);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;

                    case "rollRight":
                        int rollRightTimes = int.Parse(inputParts[1]);

                        if (rollRightTimes >= 0)
                        {
                            RollRight(list, rollRightTimes);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", list)}]");
        }

        private static void RollRight(List<string> list, int rollRightTimes)
        {
            for (int i = 0; i < rollRightTimes % list.Count; i++)
            {
                var lastElement = list[list.Count - 1];

                for (int j = list.Count - 1; j > 0; j--)
                {
                    list[j] = list[j - 1];
                }

                list[0] = lastElement;
            }
        }

        private static void RollLeft(List<string> list, int rollLeftTimes)
        {
            for (int i = 0; i < rollLeftTimes % list.Count; i++)
            {
                var firstElement = list[0];

                for (int j = 0; j < list.Count - 1; j++)
                {
                    list[j] = list[j + 1];
                }

                list[list.Count - 1] = firstElement;
            }
        }

        private static void Sort(List<string> list, int sortStart, int sortCount)
        {
            list.Sort(sortStart, sortCount, null);
        }

        private static void Reverse(List<string> list, int reverseStart, int reverseCount)
        {
            list.Reverse(reverseStart, reverseCount);
        }
    }
}