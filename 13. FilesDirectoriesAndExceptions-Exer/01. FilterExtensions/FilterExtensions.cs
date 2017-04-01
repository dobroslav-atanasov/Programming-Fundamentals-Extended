using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _01.FilterExtensions
{
    public class FilterExtensions
    {
        public static void Main()
        {
            var files = Directory.GetFiles("../../input");

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                if (fileInfo.Name.Contains(".txt"))
                {
                    File.AppendAllText("../../Output.txt", fileInfo.Name + Environment.NewLine);
                }
            }
        }
    }
}
