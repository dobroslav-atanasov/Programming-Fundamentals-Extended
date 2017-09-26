namespace _03.Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Phonebook
    {
        public static void Main()
        {
            var phoneNumbers = Console.ReadLine().Split(' ').ToArray();
            var names = Console.ReadLine().Split(' ').ToArray();

            var name = Console.ReadLine();
            while (name != "done")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (name == names[i])
                    {
                        Console.WriteLine($"{name} -> {phoneNumbers[i]}");
                    }
                }

                name = Console.ReadLine();
            }
        }
    }
}
