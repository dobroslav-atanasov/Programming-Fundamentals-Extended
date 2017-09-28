using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SoftUniKaraoke
{
    public class SoftUniKaraoke
    {
        public static void Main()
        {
            var allParticipants = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var allSongs = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            var songs = new List<string>();

            foreach (var song in allSongs)
            {
                songs.Add(song.Trim());
            }

            var performance = Console.ReadLine();

            var result = new Dictionary<string, List<string>>();

            while (performance != "dawn")
            {
                var tokens = performance.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                var participant = tokens[0].Trim();
                var song = tokens[1].Trim();
                var award = tokens[2].Trim();

                if (allParticipants.Contains(participant))
                {
                    if (songs.Contains(song))
                    {
                        if (!result.ContainsKey(participant))
                        {
                            result[participant] = new List<string>();
                        }

                        if (!result[participant].Contains(award))
                        {
                            result[participant].Add(award);
                        }
                    }
                }

                performance = Console.ReadLine();
            }

            if (result.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var participant in result.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");

                    var awards = participant.Value.OrderBy(x => x).ToList();

                    if (awards.Count > 0)
                    {
                        foreach (var award in awards)
                        {
                            Console.WriteLine($"--{award}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No awards");
                    }
                }
            }
        }
    }
}
