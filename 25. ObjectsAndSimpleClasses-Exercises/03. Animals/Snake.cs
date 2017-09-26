using System;

namespace _03.Animals
{
    public class Snake
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int CrueltyCoefficient { get; set; }
        
        public void ProduceSound()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }
    }
}
