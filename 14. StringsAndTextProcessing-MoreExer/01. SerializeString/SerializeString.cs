using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SerializeString
{
    public class SerializeString
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var symbols = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                var symbol = input[i];
                if (!symbols.Contains(symbol))
                {
                    symbols.Add(symbol);
                }
            }

            for (int i = 0; i < symbols.Count; i++)
            {
                var counts = new List<int>();
                var symbol = symbols[i];

                var index = input.IndexOf(symbol);
                counts.Add(index);

                while (true)
                {
                    index = input.IndexOf(symbol, index + 1);
                    if (index == -1)
                    {
                        break;
                    }
                    counts.Add(index);
                }

                Console.WriteLine($"{symbol}:{string.Join("/",counts)}");
            }
        }
    }
}
