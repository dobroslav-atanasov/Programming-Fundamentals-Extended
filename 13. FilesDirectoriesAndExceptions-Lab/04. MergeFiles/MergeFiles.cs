using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _04.MergeFiles
{
    public class MergeFiles
    {
        public static void Main()
        {
            var firstInput = File.ReadAllText("FileOne.txt").Split(new char[] { '\n' , '\r', ' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var secondInput = File.ReadAllText("FileTwo.txt").Split(new char[] { '\n', '\r', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < firstInput.Length; i++)
            {
                File.AppendAllText("Output.txt", firstInput[i] + Environment.NewLine + secondInput[i] + Environment.NewLine);
            }
        }
    }
}
