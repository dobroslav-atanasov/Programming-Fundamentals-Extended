using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace _04.CubicsMessages
{
    public class CubicsMessages
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            
            while (input != "Over!")
            {
                int count = int.Parse(Console.ReadLine());

                var pattern = $@"(^\d+)([A-Za-z]{{{count}}})([^A-Za-z]*$)";
                var regex = new Regex(pattern);

                var match = regex.Match(input);

                if (match.Success)
                {
                    var left = match.Groups[1].Value;
                    var message = match.Groups[2].Value;
                    var right = match.Groups[3].Value;

                    var indexes = string.Concat(left, right).Where(char.IsDigit).Select(x => x - '0');

                    var sb = new StringBuilder();

                    foreach (var index in indexes)
                    {
                        if (index < 0 || index >= message.Length)
                        {
                            sb.Append(' ');
                        }
                        else
                        {
                            sb.Append(message[index]);
                        }
                    }

                    Console.WriteLine($"{message} == {sb}");
                }
                
                input = Console.ReadLine();
            }
        }
    }
}
