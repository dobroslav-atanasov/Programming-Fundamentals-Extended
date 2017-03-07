using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.AverageStudentGrades
{
    public class AverageStudentGrades
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var studentBook = new Dictionary<string, List<double>>();

            for (int i = 1; i <= n; i++)
            {
                var tokens = Console.ReadLine().Split(' ');
                string name = tokens[0];
                double grade = double.Parse(tokens[1]);

                if (!studentBook.ContainsKey(name))
                {
                    studentBook[name] = new List<double>();
                }

                studentBook[name].Add(grade);
            }

            foreach (var item in studentBook)
            {
                var name = item.Key;
                var studentGrades = item.Value;

                var average = studentGrades.Average();

                Console.Write($"{name} -> ");
                foreach (var grade in studentGrades)
                {
                    Console.Write($"{grade:F2} ");
                }

                Console.WriteLine($"(avg: {average:F2})");
            }
        }
    }
}
