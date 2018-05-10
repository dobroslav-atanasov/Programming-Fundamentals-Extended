namespace Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, long>> files = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, string> filesWithExtension = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] inputParts = Console.ReadLine().Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                string root = inputParts[0];

                string[] fileParts = inputParts[inputParts.Length - 1].Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                string fileNameWithExtension = fileParts[0];
                long fileSize = long.Parse(fileParts[1]);

                string fileName = fileNameWithExtension;
                string fileExtension = fileNameWithExtension.Split('.')[fileNameWithExtension.Split('.').Length - 1];

                if (!files.ContainsKey(root))
                {
                    files[root] = new Dictionary<string, long>();
                }

                files[root][fileName] = fileSize;
                filesWithExtension[fileName] = fileExtension;
            }

            string[] queryParts = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string extension = queryParts[0];
            string inRoot = queryParts[2];

            Dictionary<string, long> result = new Dictionary<string, long>();

            if (files.ContainsKey(inRoot))
            {
                foreach (KeyValuePair<string, long> file in files[inRoot])
                {
                    if (filesWithExtension[file.Key] == extension)
                    {
                        result.Add(file.Key, file.Value);
                    }
                }
            }

            if (result.Count > 0)
            {
                foreach (KeyValuePair<string, long> file in result.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
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