namespace _02.TrackDownloader
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TrackDownloader
    {
        public static void Main()
        {
            var blacklist = Console.ReadLine().Split(' ').ToList();

            var filenames = Console.ReadLine();

            var result = new List<string>();
            bool isTrue = false;

            while (filenames != "end")
            {
                isTrue = false;
                foreach (var word in blacklist)
                {
                    if (filenames.Contains(word))
                    {
                        isTrue = true;
                        break;
                    }                    
                }

                if (isTrue == false)
                {
                    result.Add(filenames);
                }

                filenames = Console.ReadLine();
            }

            result.Sort();

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
