namespace _02.IntegerInsertion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IntegerInsertion
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var number = int.Parse(input);

                var firstDigit = 1;
                var num = number;
                while (num > 0)
                {
                    if (num > 0 && num < 10)
                    {
                        firstDigit = num;
                        break;
                    }
                    else
                    {
                        firstDigit = num / 10;
                        num /= 10;
                        if (firstDigit > 0 && firstDigit < 10)
                        {
                            break;
                        }
                    }                    
                }

                list.Insert(firstDigit, number);

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
