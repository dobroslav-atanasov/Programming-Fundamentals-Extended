namespace _01.Last3ConsecutiveEqualStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public class Last3ConsecutiveEqualStrings
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(' ').ToArray();

            var reverseArray = array.Reverse().ToArray();
            var result = new string[3];

            for (int i = 0; i < reverseArray.Length; i++)
            {
                if (reverseArray[i] == reverseArray[i + 1] && reverseArray[i] == reverseArray[i + 2])
                {
                    result[0] = reverseArray[i];
                    result[1] = reverseArray[i + 1];
                    result[2] = reverseArray[i + 2];
                    break;
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
