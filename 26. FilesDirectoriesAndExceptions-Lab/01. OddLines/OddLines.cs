using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _01.OddLines
{
    public class OddLines
    {
        public static void Main()
        {
            var file = File.ReadAllLines("../../Input.txt");

            for (int i = 1; i < file.Length; i += 2)
            {
                File.AppendAllText("../../Output.txt", file[i] + Environment.NewLine);
            }
        }
    }
}
