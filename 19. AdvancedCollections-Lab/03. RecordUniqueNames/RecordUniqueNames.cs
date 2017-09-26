using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.RecordUniqueNames
{
    public class RecordUniqueNames
    {
        public static void Main()
        {
            var names = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
