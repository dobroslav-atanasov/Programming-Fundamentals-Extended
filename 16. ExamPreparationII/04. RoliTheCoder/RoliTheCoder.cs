using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.RoliTheCoder
{
    public class Event
    {
        public int ID { get; set; }

        public string EventName { get; set; }

        public List<string> Participants { get; set; }
    }
    
    public class RoliTheCoder
    {
        public static void Main()
        {
            var events = new List<Event>();
            var eventsByID = new Dictionary<int, Event>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Time for Code")
                {
                    break;
                }

                var inputParts = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var eventId = 0;

                if (!int.TryParse(inputParts[0], out eventId))
                {
                    continue;
                }

                var eventName = string.Empty;

                if (inputParts.Length > 1 && inputParts[1].StartsWith("#"))
                {
                    eventName = inputParts[1].Trim('#');
                }
                else
                {
                    continue;
                }

                var participants = new List<string>();

                if (inputParts.Length > 2)
                {
                    participants = inputParts.Skip(2).ToList();

                    if (!participants.All(x => x.StartsWith("@")))
                    {
                        continue;
                    }
                }

                if (eventsByID.ContainsKey(eventId))
                {
                    if (eventsByID[eventId].EventName == eventName)
                    {
                        var existingEvent = eventsByID[eventId];
                        existingEvent.Participants.AddRange(participants);
                    }
                    else
                    {
                        continue;
                    }                                        
                }
                else
                {
                    var newEvent = new Event
                    {
                        ID = eventId,
                        EventName = eventName,
                        Participants = participants
                    };

                    events.Add(newEvent);
                    eventsByID.Add(eventId, newEvent);
                }              
            }

            var sortedEvent = events.OrderByDescending(x => x.Participants.Distinct().Count()).ThenBy(x => x.EventName);

            foreach (var ev in sortedEvent)
            {
                var distict = ev.Participants.Distinct().ToList();
                Console.WriteLine($"{ev.EventName} - {distict.Count}");

                foreach (var participant in distict.OrderBy(x => x))
                {
                    Console.WriteLine($"{participant}");
                }
            }
        }
    }
}
