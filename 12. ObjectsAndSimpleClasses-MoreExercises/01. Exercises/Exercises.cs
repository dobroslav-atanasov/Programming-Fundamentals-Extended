using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Exercises
{
    public class Exercises
    {
        public static void Main()
        {
            var exercises = new List<Exercise>();

            var input = Console.ReadLine();

            while (input != "go go go")
            {
                var newExercises = ReadCollection(input);

                exercises.Add(newExercises);

                input = Console.ReadLine();
            }

            foreach (var exercise in exercises)
            {
                Console.WriteLine($"Exercises: {exercise.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{exercise.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {exercise.JudgeContestLink}");
                for (int i = 0; i < exercise.Problems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {exercise.Problems[i]}");
                }
            }

        }

        public static Exercise ReadCollection(string input)
        {
            var tokens = input.Split(new char[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            return new Exercise
            {
                Topic = tokens[0],
                CourseName = tokens[1],
                JudgeContestLink = tokens[2],
                Problems = tokens.Skip(3).ToList()
            };
        }
    }
}
