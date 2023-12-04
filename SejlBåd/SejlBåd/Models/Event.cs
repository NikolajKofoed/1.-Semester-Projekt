using Microsoft.AspNetCore.Mvc;

namespace SejlBåd.Models
{
    public class Event
    {
        private static int _nextId = 1;
        [BindProperty]
        public int EventId { get; set; }
        [BindProperty]
        public string EventName { get; set; }
        [BindProperty]
        public string EventDescription { get; set; }
        [BindProperty]
        public string EventDate { get; set; }

        public Event(int eventId, string eventName, string eventDescription, string eventDate)
        {
            EventId = _nextId++;
            EventName = eventName;
            EventDescription = eventDescription;
            EventDate = eventDate;
        }

        public Event()
        {
            EventId = _nextId++;
            EventName = "Default Name";
            EventDescription = "Default Description";
            EventDate = "Default Date";
        }
    }
}
