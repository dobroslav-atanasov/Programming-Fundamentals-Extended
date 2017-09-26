using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Boxes
{
    public class Boxes
    {
        public static void Main()
        {
            var boxes = new List<Box>();
            var newBox = default(Box);

            var input = Console.ReadLine();
            
            while (input != "end")
            {
                newBox = ReadBox(input);

                boxes.Add(newBox);
                
                input = Console.ReadLine();
            }

            foreach (var box in boxes)
            {
                Console.WriteLine($"Box: {box.Width}, {box.Height}");
                Console.WriteLine($"Perimeter: {Box.CalculatePerimeter(box.Width, box.Height)}");
                Console.WriteLine($"Area: {Box.CalculateArea(box.Width, box.Height)}");
            }
        }

        public static Box ReadBox(string input)
        {
            var tokens = input.Split(new[] { ' ', '|', ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            return new Box
            {
                UpperLeft = new Point
                {
                    X = int.Parse(tokens[0]),
                    Y = int.Parse(tokens[1]),
                },
                UpperRight = new Point
                {
                    X = int.Parse(tokens[2]),
                    Y = int.Parse(tokens[3])
                },
                BottomLeft = new Point
                {
                    X = int.Parse(tokens[4]),
                    Y = int.Parse(tokens[5])
                },
                BottomRight = new Point
                {
                    X = int.Parse(tokens[6]),
                    Y = int.Parse(tokens[7])
                }
            };
        }
    }
}
