using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.FilterBase
{
    public class FilterBase
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var ageDict = new Dictionary<string, int>();
            var salaryDict = new Dictionary<string, double>();
            var positionDict = new Dictionary<string, string>();

            while (input != "filter base")
            {
                var tokens = input.Split(new char[] { '-', '>', ' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = tokens[0];

                var number = 0;
                var numberDouble = 0.0;
                if (int.TryParse(tokens[1], out number))
                {
                    if (!ageDict.ContainsKey(name))
                    {
                        ageDict[name] = 0;
                    }
                    ageDict[name] = number;
                }
                else if (double.TryParse(tokens[1], out numberDouble))
                {
                    if (!salaryDict.ContainsKey(name))
                    {
                        salaryDict[name] = 0;
                    }
                    salaryDict[name] = numberDouble;
                }
                else
                {
                    if (!positionDict.ContainsKey(name))
                    {
                        positionDict[name] = string.Empty;
                    }
                    positionDict[name] = tokens[1];
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            if (input == "Age")
            {
                foreach (var item in ageDict)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Age: {item.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (input == "Salary")
            {
                foreach (var item in salaryDict)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Salary: {item.Value:F2}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (input == "Position")
            {
                foreach (var item in positionDict)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Position: {item.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
        }
    }
}
