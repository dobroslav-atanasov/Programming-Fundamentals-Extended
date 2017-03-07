namespace _05.NoteStatistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NoteStatistics
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            var notes = new string[] { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
            var frequency = new double[] { 261.63, 277.18, 293.66, 311.13, 329.63, 349.23, 369.99, 392.00, 415.30, 440.00, 466.16, 493.88 };

            var result = new List<string>();

            foreach (var item in list)
            {
                var frequencyIndex = Array.IndexOf(frequency, item);
                var note = notes[frequencyIndex];

                result.Add(note);
            }

            Console.WriteLine($"Notes: {string.Join(" ", result)}");

            var resultNaturals = new List<string>();
            var resultSharps = new List<string>();

            foreach (var item in result)
            {
                if (!item.Contains("#"))
                {
                    resultNaturals.Add(item);
                }
                else
                {
                    resultSharps.Add(item);
                }
            }

            Console.WriteLine($"Naturals: {string.Join(", ", resultNaturals)}");
            Console.WriteLine($"Sharps: {string.Join(", ", resultSharps)}");

            var naturalsSum = 0.0;
            var sharpsSum = 0.0;

            foreach (var item in list)
            {
                var frequencyIndex = Array.IndexOf(frequency, item);
                var note = notes[frequencyIndex];

                if (!note.Contains("#"))
                {
                    naturalsSum += item;
                }
                else
                {
                    sharpsSum += item;
                }
            }

            Console.WriteLine($"Naturals sum: {naturalsSum}");
            Console.WriteLine($"Sharps sum: {sharpsSum}");
        }
    }
}
