using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Files
{
    public class Files
    {
        public static void Main()
        {
            var files = new Dictionary<string, Dictionary<string, long>>();
            var filesWithExtension = new Dictionary<string, string>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                var inputParts = Console.ReadLine().Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                var root = inputParts[0];

                var fileParts = inputParts[inputParts.Length - 1].Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                var fileNameWithExtension = fileParts[0];
                var fileSize = long.Parse(fileParts[1]);

                var fileName = fileNameWithExtension;
                var fileExtension = fileNameWithExtension.Split('.')[fileNameWithExtension.Split('.').Length - 1];

                if (!files.ContainsKey(root))
                {
                    files[root] = new Dictionary<string, long>();
                }

                files[root][fileName] = fileSize;
                filesWithExtension[fileName] = fileExtension;
            }

            var queryParts = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var extension = queryParts[0];
            var inRoot = queryParts[2];

            var result = new Dictionary<string, long>();

            if (files.ContainsKey(inRoot))
            {
                foreach (var file in files[inRoot])
                {
                    if (filesWithExtension[file.Key] == extension)
                    {
                        result.Add(file.Key, file.Value);
                    }
                }
            }

            if (result.Count > 0)
            {
                foreach (var file in result.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{file.Key} - {file.Value} KB");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
