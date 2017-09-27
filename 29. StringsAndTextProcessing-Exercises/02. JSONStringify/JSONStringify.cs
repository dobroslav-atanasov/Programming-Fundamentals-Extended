using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.JSONStringify
{
    public class JSONStringify
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var students = new List<Student>();

            while (input != "stringify")
            {
                var tokens = input.Split(new char[] { ' ', ':', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);

                var student = new Student
                {
                    Name = tokens[0],
                    Age = int.Parse(tokens[1]),
                    Grades = tokens.Skip(2).ToList()
                };

                students.Add(student);

                input = Console.ReadLine();
            }

            var result = new List<string>();
            
            foreach (var student in students)
            {
                var partOfResult = $"{{name:\"{student.Name}\",age:{student.Age},grades:[{string.Join(", ", student.Grades)}]}}";

                result.Add(partOfResult);
            }

            Console.WriteLine($"[{string.Join(",", result)}]");
        }
    }
}
