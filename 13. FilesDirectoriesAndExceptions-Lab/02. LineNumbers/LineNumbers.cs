using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _02.LineNumbers
{
    public class LineNumbers
    {
        public static void Main()
        {
            var file = File.ReadAllLines("Input.txt");

            for (int i = 0; i < file.Length; i++)
            {
                File.AppendAllText("Output.txt", $"{i + 1}. {file[i] + Environment.NewLine}");
            }
        }
    }
}
