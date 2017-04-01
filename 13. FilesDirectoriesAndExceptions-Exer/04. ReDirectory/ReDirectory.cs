using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _04.ReDirectory
{
    public class ReDirectory
    {
        public static void Main()
        {
            var files = Directory.GetFiles("../../input");

            foreach (var file in files)
            {
                if (file.Contains(".txt"))
                {
                    File.Copy($"{file}", "../../Output/txts/test.txt");
                }
            }
        }
    }
}
