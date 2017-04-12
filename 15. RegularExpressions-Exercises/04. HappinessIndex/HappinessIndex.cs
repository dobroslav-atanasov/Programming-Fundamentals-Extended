using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.HappinessIndex
{
    public class HappinessIndex
    {
        public static void Main()
        {
            var happyRegex = new Regex(@"(\:\))|(\:D)|(\;\))|(\:\*)|(\:\])|(\;\])|(\:\})|(\;\})|(\(\:)|(\*\:)|(c\:)|(\[\:)|(\[\;)");
            var sadRegex = new Regex(@"(\:\()|(D\:)|(\;\()|(\:\[)|(\;\[)|(\:\{)|(\;\{)|(\)\:)|(\:c)|(\]\:)|(\]\;)");
            
            var input = Console.ReadLine();

            int happyCount = happyRegex.Matches(input).Count;
            int sadCount = sadRegex.Matches(input).Count;

            double happyIndex = happyCount / (double) sadCount;

            var status = string.Empty;

            if (happyIndex >= 2)
            {
                status = ":D";
            }
            else if (happyIndex > 1)
            {
                status = ":)";
            }
            else if (happyIndex == 1)
            {
                status = ":|";
            }
            else if (happyIndex < 1)
            {
                status = ":(";
            }

            Console.WriteLine($"Happiness index: {happyIndex:F2} {status}");
            Console.WriteLine($"[Happy count: {happyCount}, Sad count: {sadCount}]");
        }
    }
}
