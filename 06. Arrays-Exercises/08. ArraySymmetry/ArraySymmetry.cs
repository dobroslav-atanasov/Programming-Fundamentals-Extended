namespace _08.ArraySymmetry
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArraySymmetry
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(' ').ToArray();
            
            var reverseArray = array.Reverse().ToArray();
            bool isSymmetry = true;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == reverseArray[i])
                {
                    isSymmetry = true;
                }
                else
                {
                    isSymmetry = false;
                    break;
                }
            }

            if (isSymmetry == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
