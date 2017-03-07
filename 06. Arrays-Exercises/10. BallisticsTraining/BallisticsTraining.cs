namespace _10.BallisticsTraining
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BallisticsTraining
    {
        public static void Main()
        {
            var target = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var commands = Console.ReadLine().Split(' ').ToArray();
            
            var xPosition = 0.0;
            var yPosition = 0.0;
 
            for (int i = 0; i < commands.Length - 1; i += 2)
            {
                if (commands[i] == "up")
                {
                    yPosition += double.Parse(commands[i + 1]);
                }
                else if (commands[i] == "down")
                {
                    yPosition -= double.Parse(commands[i + 1]);
                }
                else if (commands[i] == "left")
                {
                    xPosition -= double.Parse(commands[i + 1]);
                }
                else if (commands[i] == "right")
                {
                    xPosition += double.Parse(commands[i + 1]);
                }
            }

            Console.WriteLine($"firing at [{xPosition}, {yPosition}]");
            if (target[0] == xPosition && target[1] == yPosition)
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
