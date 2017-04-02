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
            var allFiles = Directory.GetFiles("input");

            Directory.CreateDirectory("output");
            Directory.CreateDirectory("output/txts");
            Directory.CreateDirectory("output/pngs");
            Directory.CreateDirectory("output/tests");

            var txtFiles = new List<string>();
            var pngFiles = new List<string>();
            var testFiles = new List<string>();

            foreach (var file in allFiles)
            {
                var currentFile = new FileInfo(file);
                var extension = currentFile.Extension;

                switch (extension)
                {
                    case ".txt":
                        txtFiles.Add(file);
                        break;
                    case ".png":
                        pngFiles.Add(file);
                        break;
                    case ".test":
                        testFiles.Add(file);
                        break;
                }
            }

            TransferFiles(txtFiles, pngFiles, testFiles);
        }

        private static void TransferFiles(List<string> txtFiles, List<string> pngFiles, List<string> testFiles)
        {
            foreach (var txtFile in txtFiles)
            {
                var currentFile = new FileInfo(txtFile);
                var txtFileAsString = currentFile.Name;

                File.Move(txtFile, "output/txts/" + txtFileAsString);
            }

            foreach (var pngFile in pngFiles)
            {
                var currentFile = new FileInfo(pngFile);
                var pngFileAsString = currentFile.Name;

                File.Move(pngFile, "output/pngs/" + pngFileAsString);
            }

            foreach (var testFile in testFiles)
            {
                var currentFile = new FileInfo(testFile);
                var testFileAsString = currentFile.Name;

                File.Move(testFile, "output/tests/" + testFileAsString);

            }
        }
    }
}
