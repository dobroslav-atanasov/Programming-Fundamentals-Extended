namespace _07.ResizableArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ResizableArray
    {
        public static void Main()
        {
            //var array = new int[8];

            //var command = Console.ReadLine().Split(' ').ToArray();
            //var pushCount = 0;

            //while (command[0] != "end")
            //{
            //    if (command[0] == "push")
            //    {
            //        pushCount++;
            //        for (int i = 0; i < array.Length; i++)
            //        {
            //            if (array[i] == 0)
            //            {
            //                array[i] = int.Parse(command[1]);
            //                break;
            //            }
            //        }
            //    }

            //    if (command[0] == "removeAt")
            //    {
            //        array[int.Parse(command[1])] = 0;
            //    }
            //    else if (command[0] == "pop")
            //    {
            //        for (int i = array.Length - 1; i >= 0; i--)
            //        {
            //            if (array[i] != 0)
            //            {
            //                array[i] = 0;
            //                break;
            //            }
            //        }
            //    }
            //    else if (command[0] == "clear")
            //    {
            //        for (int i = 0; i < array.Length; i++)
            //        {
            //            array[i] = 0;
            //        }
            //    }

            //    command = Console.ReadLine().Split(' ').ToArray();
            //}

            //var sum = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] != 0)
            //    {
            //        Console.Write(array[i] + " ");
            //    }
            //    sum += array[i];
            //}

            //if (sum == 0)
            //{
            //    Console.WriteLine("empty array");
            //}

            //Console.WriteLine();

            var list = new List<int>();

            var command = Console.ReadLine().Split().ToArray();

            while (command[0] != "end")
            {
                if (command[0] == "push")
                {
                    list.Add(int.Parse(command[1]));
                }
                else if (command[0] == "pop")
                {
                    list.RemoveAt(list.Count - 1);
                }
                else if (command[0] == "removeAt")
                {
                    list.RemoveAt(int.Parse(command[1]));
                }
                else if (command[0] == "clear")
                {
                    list.Clear();
                }
                command = Console.ReadLine().Split().ToArray();
            }

            if (list.Count > 0)
            {
                Console.WriteLine(string.Join(" ", list));
            }
            else
            {
                Console.WriteLine("empty array");
            }
            
        }
    }
}
