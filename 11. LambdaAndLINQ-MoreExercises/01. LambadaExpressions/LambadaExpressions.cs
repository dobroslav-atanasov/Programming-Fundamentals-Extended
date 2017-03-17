using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.LambadaExpressions
{
    public class LambadaExpressions
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var lambadaExp = new Dictionary<string, Dictionary<string, string>>();

            while (input != "lambada")
            {
                var tokens = input.Split(new char[] { ' ', '=', '>', '.' }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length > 1)
                {
                    var selector = tokens[0];
                    var selectorObject = tokens[1];
                    var property = tokens[2];

                    if (!lambadaExp.ContainsKey(selector))
                    {
                        lambadaExp.Add(selector, new Dictionary<string, string>());
                    }

                    lambadaExp[selector][selectorObject] = property;
                }
                else
                {
                    lambadaExp = lambadaExp.ToDictionary(x => x.Key, x => x.Value.ToDictionary(y => y.Key, y => y.Key + "." + y.Value));
                }

                input = Console.ReadLine();
            }

            foreach (var selecor in lambadaExp)
            {
                foreach (var selectorObject in selecor.Value)
                {
                    Console.WriteLine($"{selecor.Key} => {selectorObject.Key}.{selectorObject.Value}");
                }
            }

        }
    }
}
