using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.FishStatistics
{
    public class FishStatistics
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var pattern = @"(>*)<(\(+)([\'\-x])>";

            var regex = new Regex(pattern);

            var matches = regex.Matches(input);

            if (matches.Count == 0)
            {
                Console.WriteLine("No fish found.");
            }
            else
            {
                for (int i = 0; i < matches.Count; i++)
                {
                    Console.WriteLine($"Fish {i + 1}: {matches[i]}");

                    var tailType = string.Empty;
                    var tailLength = matches[i].Groups[1].Length;
                    if (tailLength > 5)
                    {
                        tailType = "Long";
                    }
                    else if (tailLength > 1 && tailLength <= 5)
                    {
                        tailType = "Medium";
                    }
                    else if (tailLength == 1)
                    {
                        tailType = "Short";
                    }
                    else if (tailLength == 0)
                    {
                        tailType = "None";
                    }

                    if (tailType == "None")
                    {
                        Console.WriteLine($"  Tail type: None");
                    }
                    else
                    {
                        Console.WriteLine($"  Tail type: {tailType} ({tailLength * 2} cm)");
                    }

                    var bodyTypes = string.Empty;
                    var bodyLength = matches[i].Groups[2].Length;
                    if (bodyLength > 10)
                    {
                        bodyTypes = "Long";
                    }
                    else if (bodyLength > 5 && bodyLength <= 10)
                    {
                        bodyTypes = "Medium";
                    }
                    else if (bodyLength <= 5)
                    {
                        bodyTypes = "Short";
                    }

                    Console.WriteLine($"  Body type: {bodyTypes} ({bodyLength * 2} cm)");

                    var status = matches[i].Groups[3].Value;
                    if (status == "\'")
                    {
                        Console.WriteLine("  Status: Awake");
                    }
                    else if (status == "-")
                    {
                        Console.WriteLine("  Status: Asleep");
                    }
                    else if (status == "x")
                    {
                        Console.WriteLine("  Status: Dead");
                    }
                }
            }
        }
    }
}
