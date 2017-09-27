using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _02.CriticalBreakpoint
{
    public class Line
    {
        public int x1 { get; set; }

        public int y1 { get; set; }

        public int x2 { get; set; }

        public int y2 { get; set; }

        public BigInteger CriticalRatio { get; set; }
    }

    public class CriticalBreakpoint
    {
        public static void Main()
        {
            List<Line> lists = new List<Line>();
            var inputLine = Console.ReadLine();

            while (inputLine != "Break it.")
            {
                int[] inputLineParts = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                Line newLine = new Line
                {
                    x1 = inputLineParts[0],
                    y1 = inputLineParts[1],
                    x2 = inputLineParts[2],
                    y2 =inputLineParts[3],
                    CriticalRatio = BigInteger.Abs(((long)inputLineParts[2] + inputLineParts[3]) - ((long)inputLineParts[0] + inputLineParts[1]))
                };

                lists.Add(newLine);
                                
                inputLine = Console.ReadLine();
            }

            bool isBreakPoint = true;

            BigInteger actualRatio = 0;

            foreach (var line in lists)
            {
                if (actualRatio == 0 && line.CriticalRatio != 0)
                {
                    actualRatio = line.CriticalRatio;
                }

                if ((line.CriticalRatio != actualRatio) && (line.CriticalRatio != 0))
                {
                    isBreakPoint = false;
                    break;
                }
            }

            if (isBreakPoint)
            {
                BigInteger totalRatio = BigInteger.Pow(actualRatio, lists.Count);
                BigInteger criticalBreakpoint = 0;
                BigInteger.DivRem(totalRatio, lists.Count, out criticalBreakpoint);

                foreach (var line in lists)
                {
                    Console.WriteLine($"Line: [{line.x1}, {line.y1}, {line.x2}, {line.y2}]");
                }

                Console.WriteLine($"Critical Breakpoint: {criticalBreakpoint}");
            }
            else
            {
                Console.WriteLine("Critical breakpoint does not exist.");
            }
        }
    }
}
