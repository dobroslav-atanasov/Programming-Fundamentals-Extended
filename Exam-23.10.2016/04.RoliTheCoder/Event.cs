namespace RoliTheCoder
{
    using System.Collections.Generic;

    public class Event
    {
        public int ID { get; set; }

        public string EventName { get; set; }

        public List<string> Participants { get; set; }
    }
}