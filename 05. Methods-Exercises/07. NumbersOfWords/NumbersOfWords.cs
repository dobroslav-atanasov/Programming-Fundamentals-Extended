using System;

namespace _07.NumbersOfWords
{
    public class NumbersOfWords
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                string words = "";

                if (number > 999)
                {
                    Console.WriteLine("too large");
                }
                else if (number < -999)
                {
                    Console.WriteLine("too small");
                }
                if (100 <= number && number <= 999)
                {
                    int thirdDigit = number % 10;
                    int secondDigit = (number / 10) % 10;
                    int firstDigit = (number / 100) % 10;
                    
                    switch (firstDigit)
                    {
                        case 1: words += "one-hundred"; break;
                        case 2: words += "two-hundred"; break;
                        case 3: words += "three-hundred"; break;
                        case 4: words += "four-hundred"; break;
                        case 5: words += "five-hundred"; break;
                        case 6: words += "six-hundred"; break;
                        case 7: words += "seven-hundred"; break;
                        case 8: words += "eight-hundred"; break;
                        case 9: words += "nine-hundred"; break;
                        default: break;
                    }

                    if (secondDigit == 0 && thirdDigit != 0)
                    {
                        words += " and ";
                    }

                    if (secondDigit == 1)
                    {
                        switch (thirdDigit)
                        {
                            case 0: words += " and ten"; break;
                            case 1: words += " and eleven"; break;
                            case 2: words += " and twelve"; break;
                            case 3: words += " and thirteen"; break;
                            case 4: words += " and fourteen"; break;
                            case 5: words += " and fifteen"; break;
                            case 6: words += " and sixteen"; break;
                            case 7: words += " and seventeen"; break;
                            case 8: words += " and eighteen"; break;
                            case 9: words += " and nineteen"; break;
                            default: break;
                        }
                    }
                    else
                    {
                        switch (secondDigit)
                        {
                            case 2: words += " and twenty "; break;
                            case 3: words += " and thirty "; break;
                            case 4: words += " and fourty "; break;
                            case 5: words += " and fifty "; break;
                            case 6: words += " and sixty "; break;
                            case 7: words += " and seventy "; break;
                            case 8: words += " and eighty "; break;
                            case 9: words += " and ninety "; break;
                            default: break;
                        }

                        switch (thirdDigit)
                        {
                            case 1: words += "one"; break;
                            case 2: words += "two"; break;
                            case 3: words += "three"; break;
                            case 4: words += "four"; break;
                            case 5: words += "five"; break;
                            case 6: words += "six"; break;
                            case 7: words += "seven"; break;
                            case 8: words += "eight"; break;
                            case 9: words += "nine"; break;
                            default: break;
                        }
                    }
                }
                if (-100 >= number && number >= -999)
                {
                    int thirdDigit = Math.Abs(number) % 10;
                    int secondDigit = (Math.Abs(number) / 10) % 10;
                    int firstDigit = (Math.Abs(number) / 100) % 10;

                    switch (firstDigit)
                    {
                        case 1: words += "minus one-hundred"; break;
                        case 2: words += "minus two-hundred"; break;
                        case 3: words += "minus three-hundred"; break;
                        case 4: words += "minus four-hundred"; break;
                        case 5: words += "minus five-hundred"; break;
                        case 6: words += "minus six-hundred"; break;
                        case 7: words += "minus seven-hundred"; break;
                        case 8: words += "minus eight-hundred"; break;
                        case 9: words += "minus nine-hundred"; break;
                        default: break;
                    }

                    if (secondDigit == 0 && thirdDigit != 0)
                    {
                        words += " and ";
                    }

                    if (secondDigit == 1)
                    {
                        switch (thirdDigit)
                        {
                            case 0: words += " and ten"; break;
                            case 1: words += " and eleven"; break;
                            case 2: words += " and twelve"; break;
                            case 3: words += " and thirteen"; break;
                            case 4: words += " and fourteen"; break;
                            case 5: words += " and fifteen"; break;
                            case 6: words += " and sixteen"; break;
                            case 7: words += " and seventeen"; break;
                            case 8: words += " and eighteen"; break;
                            case 9: words += " and nineteen"; break;
                            default: break;
                        }
                    }
                    else
                    {
                        switch (secondDigit)
                        {
                            case 2: words += " and twenty "; break;
                            case 3: words += " and thirty "; break;
                            case 4: words += " and fourty "; break;
                            case 5: words += " and fifty "; break;
                            case 6: words += " and sixty "; break;
                            case 7: words += " and seventy "; break;
                            case 8: words += " and eighty "; break;
                            case 9: words += " and ninety "; break;
                            default: break;
                        }

                        switch (thirdDigit)
                        {
                            case 1: words += "one"; break;
                            case 2: words += "two"; break;
                            case 3: words += "three"; break;
                            case 4: words += "four"; break;
                            case 5: words += "five"; break;
                            case 6: words += "six"; break;
                            case 7: words += "seven"; break;
                            case 8: words += "eight"; break;
                            case 9: words += "nine"; break;
                            default: break;
                        }
                    }
                }

                Console.WriteLine(words);
            }
        }
    }
}
