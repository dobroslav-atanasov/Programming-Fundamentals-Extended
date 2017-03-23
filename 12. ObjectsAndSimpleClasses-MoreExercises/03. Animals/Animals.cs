using System;
using System.Collections.Generic;
using System.Linq;
namespace _03.Animals
{
    public class Animals
    {
        public static void Main()
        {
            var dogs = new Dictionary<string, Dog>();
            var cats = new Dictionary<string, Cat>();
            var snakes = new Dictionary<string, Snake>();

            var input = Console.ReadLine();

            while (input != "I'm your Huckleberry")
            {
                var tokens = input.Split(' ').ToArray();
                var type = tokens[0];
                var animalName = tokens[1];

                if (type == "Dog")
                {
                    var newDog = ReadDog(input);

                    dogs.Add(newDog.Name, newDog);
                }
                else if (type == "Cat")
                {
                    var newCat = ReadCat(input);

                    cats.Add(newCat.Name, newCat);
                }
                else if (type == "Snake")
                {
                    var newSnake = ReadSnake(input);

                    snakes.Add(newSnake.Name, newSnake);
                }
                else if (type == "talk")
                {
                    if (dogs.ContainsKey(animalName))
                    {
                        dogs[animalName].ProduceSound();
                    }
                    else if (cats.ContainsKey(animalName))
                    {
                        cats[animalName].ProduceSound();
                    }
                    else if (snakes.ContainsKey(animalName))
                    {
                        snakes[animalName].ProduceSound();
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var dog in dogs.Values)
            {
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs}");
            }

            foreach (var cat in cats.Values)
            {
                Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.IntelligenceQuotient}");
            }

            foreach (var snake in snakes.Values)
            {
                Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.CrueltyCoefficient}");
            }
        }

        public static Snake ReadSnake(string input)
        {
            var tokes = input.Split(' ').ToArray();

            return new Snake
            {
                Name = tokes[1],
                Age = int.Parse(tokes[2]),
                CrueltyCoefficient = int.Parse(tokes[3])
            };
        }

        public static Cat ReadCat(string input)
        {
            var tokes = input.Split(' ').ToArray();

            return new Cat
            {
                Name = tokes[1],
                Age = int.Parse(tokes[2]),
                IntelligenceQuotient = int.Parse(tokes[3])
            };
        }

        public static Dog ReadDog(string input)
        {
            var tokes = input.Split(' ').ToArray();

            return new Dog
            {
                Name = tokes[1],
                Age = int.Parse(tokes[2]),
                NumberOfLegs = int.Parse(tokes[3])
            };
        }
    }
}
