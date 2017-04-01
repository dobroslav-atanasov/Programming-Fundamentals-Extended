using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace _02.HTMLContents
{
    public class HTMLContents
    {
        public static void Main()
        {
            var lines = File.ReadAllLines("../../Input.txt");

            var title = string.Empty;
            var bodyParts = new List<string>();

            foreach (var line in lines)
            {
                if (line == "exit")
                {
                    break;
                }

                var tokens = line.Split(' ');

                var tag = tokens[0];
                var content = tokens[1];

                if (tag == "title")
                {
                    title = content;
                }
                else
                {
                    bodyParts.Add($"\t<{tag}>{content}</{tag}>");
                }
            }

            var result = new StringBuilder();

            result.AppendLine("<!DOCTYPE html>");
            result.AppendLine("<html>");
            result.AppendLine("<head>");

            if (title != string.Empty)
            {
                result.AppendLine($"\t<title>{title}</title>");
            }

            result.AppendLine("</head>");
            result.AppendLine("<body>");

            if (bodyParts.Any())
            {
                result.AppendLine(string.Join(Environment.NewLine, bodyParts));
            }

            result.AppendLine("</body>");
            result.AppendLine("</html>");

            File.WriteAllText("../../index.html", result.ToString());
        }
    }
}
