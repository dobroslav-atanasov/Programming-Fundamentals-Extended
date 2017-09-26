using System;

namespace _03.Animals
{
    public class Cat
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int IntelligenceQuotient { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }
    }
}
