namespace SejlBåd.Repositories
{
    public class EventRepository
    {
        List<Models.Event> EventList = new List<Models.Event>();

        public void AddEvent(string eventName, string eventDetails, DateTime eventDate)
        {
            EventList.Add(new Models.Event { EventName = eventName, EventDetails = eventDetails, EventDate = eventDate });
        }

        public void UpdateEvent(string eventName, string eventDetails, DateTime eventDate)
        {
            Models.Event EventToUpdate = EventList.FirstOrDefault(e => e.EventName == eventName);
            if (EventToUpdate != null)
            {
                EventToUpdate.EventName = eventName;
                EventToUpdate.EventDetails = eventDetails;
                EventToUpdate.EventDate = eventDate;
            }
        }

        public void DeleteEvent(string eventName)
        {
            Models.Event EventToDelete = EventList.FirstOrDefault(e => e.EventName == eventName);
            if (EventToDelete != null)
            {
                EventList.Remove(EventToDelete);
            }
        }

        public Models.Event GetEventByName(string eventName)
        {
            return EventList.FirstOrDefault(e => e.EventName == eventName);
        }
    }
}
