using System;

namespace _07.GreaterOfTwoValues
{
    public class GreaterOfTwoValues
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            if (input == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int result = GetMax(a, b);
                Console.WriteLine(result);
            }
            else if (input == "char")
            {
                char symbol1 = char.Parse(Console.ReadLine());
                char symbol2 = char.Parse(Console.ReadLine());
                char result = GetMax(symbol1, symbol2);
                Console.WriteLine(result); 
            }
            else if (input == "string")
            {
                string text1 = Console.ReadLine();
                string text2 = Console.ReadLine();
                string result = GetMax(text1, text2);
                Console.WriteLine(result);
            }
        }

        public static string GetMax(string text1, string text2)
        {
            if (text1.CompareTo(text2) >= 0)
            {
                return text1;
            }
            else
            {
                return text2;
            }
        }

        public static char GetMax(char symbol1, char symbol2)
        {
            if (symbol1 >= symbol2)
            {
                return symbol1;
            }
            else
            {
                return symbol2;
            }
        }

        public static int GetMax(int a, int b)
        {
            if (a >= b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
