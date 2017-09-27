using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Pyramidic
{
    public class Pyramidic
    {
        public static void Main()
        {
            var pyramids = new List<string>();
            
            var n = int.Parse(Console.ReadLine());
            var lines = new string[n];

            for (int i = 0; i < n; i++)
            {
                lines[i] = Console.ReadLine();
            }

            for (int i = 0; i < lines.Length; i++)
            {
                var currentLine = lines[i];

                for (int j = 0; j < currentLine.Length; j++)
                {
                    var currentSymbol = currentLine[j];
                    var layer = 1;
                    var currentPyramid = "";

                    for (int k = i; k < lines.Length; k++)
                    {
                        var currentLayer = new string(currentSymbol, layer);

                        if (lines[k].Contains(currentLayer))
                        {
                            currentPyramid += currentLayer + Environment.NewLine;
                        }
                        else
                        {
                            break;
                        }

                        layer += 2;
                    }

                    pyramids.Add(currentPyramid.Trim());
                }
            }

            Console.WriteLine(pyramids.OrderByDescending(x => x.Length).First());
        }
    }
}
