using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ShootListElements
{
    public class ShootListElements
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var list = new List<int>();
            var lastElement = 0;
            var average = 0.0;

            while (input != "stop")
            {
                if (input != "bang")
                {
                    list.Insert(0, int.Parse(input));
                }
                else
                {
                    average = list.Average();
                    for (int i = 0; i < list.Count; i++)
                    {
                        lastElement = list[i];
                        if (lastElement < average)
                        {
                            list.Remove(lastElement);
                            Console.WriteLine($"shot {lastElement}");
                            break;
                        }
                        else if (lastElement >= average && list.Count == 1)
                        {
                            list.Remove(lastElement);
                            Console.WriteLine($"shot {lastElement}");
                            break;
                        }
                    }
                    
                    for (int i = 0; i < list.Count; i++)
                    {
                        list[i]--;
                    }
                }
                
                input = Console.ReadLine();

                if (list.Count == 0)
                {
                    break;
                }
            }

            if (lastElement >= average && list.Count == 0 && input != "stop")
            {
                Console.WriteLine($"nobody left to shoot! last one was {lastElement}");
            }
            else if (list.Count == 0 && input == "stop")
            {
                Console.WriteLine($"you shot them all. last one was {lastElement}");
            }
            else if (list.Count >= 1)
            {
                Console.WriteLine($"survivors: {string.Join(" ", list)}");
            }
        }
    }
}
