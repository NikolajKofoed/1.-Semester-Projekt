namespace SejlBåd.Repositories
{
    public class EventRepository
    {
        List<Models.Event> EventList = new List<Models.Event>();

        public void AddEvent(string eventName, string eventDetails, string eventDate)
        {
            EventList.Add(new Models.Event { EventName = eventName, EventDetails = eventDetails, EventDate = eventDate });
        }

        public void RemoveEvent(string eventName)
        {
            Models.Event EventToRemove = EventList.FirstOrDefault(e => e.EventName == eventName);
            if (EventToRemove != null)
            {
                EventList.Remove(EventToRemove);
            }
        }

        public void UpdateEvent(string eventName, string eventDetails, string eventDate)
        {
            Models.Event EventToUpdate = EventList.FirstOrDefault();
            if (EventToUpdate != null)
            {
                EventToUpdate.EventName = eventName;
                EventToUpdate.EventDetails = eventDetails;
                EventToUpdate.EventDate = eventDate;
            }
        }

        public void DeleteEvent(string eventName)
        {
            Models.Event EventToDelete = EventList.FirstOrDefault();
            if (EventToDelete != null)
            {
                EventList.Remove(EventToDelete);
            }
        }
    }
}
