using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.JSONParse
{
    public class JSONParse
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var firstPattern = "{";
            var secondPattern = "}";

            var indexOfFirtst = input.IndexOf(firstPattern);
            var indexOfSecond = input.IndexOf(secondPattern);
            var partOfStudent = string.Empty;

            var students = new List<Student>();
            var student = new Student();

            while (indexOfFirtst != -1)
            {
                partOfStudent = input.Substring(indexOfFirtst, (indexOfSecond - indexOfFirtst));
                var tokens = partOfStudent.Split(new char[] { '{', '}', ':', '\"', ',', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);

                student.Name = tokens[1];
                student.Age = int.Parse(tokens[3]);
                student.Grades = new List<int>();

                for (int i = 5; i < tokens.Length; i++)
                {
                    student.Grades.Add(int.Parse(tokens[i]));
                }

                if (student.Grades.Count == 0)
                {
                    Console.WriteLine($"{student.Name} : {student.Age} -> None");
                }
                else
                {
                    Console.WriteLine($"{student.Name} : {student.Age} -> {string.Join(", ", student.Grades)}");
                }

                indexOfFirtst = input.IndexOf(firstPattern, indexOfFirtst + 1);
                indexOfSecond = input.IndexOf(secondPattern, indexOfFirtst + 1);
                partOfStudent = string.Empty;
            }
        }
    }
}
